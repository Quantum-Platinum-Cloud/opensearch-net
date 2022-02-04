/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
* 	http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/

using System;
using System.Collections.Generic;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using FluentAssertions;
using Osc;
using Tests.Core.Extensions;
using Tests.Core.ManagedOpenSearch.Clusters;
using Tests.Domain;
using Tests.Framework.EndpointTests.TestState;
using static Osc.Infer;

namespace Tests.Aggregations.Metric.Boxplot
{
	/**
	 * A boxplot metrics aggregation that computes boxplot of numeric values extracted from the aggregated documents.
	 * These values can be generated by a provided script or extracted from specific numeric or histogram fields in the documents.
	 *
	 * boxplot aggregation returns essential information for making a box plot: minimum, maximum median, first quartile (25th percentile)
	 * and third quartile (75th percentile) values.
	 *
	 * Be sure to read the OpenSearch documentation on {ref_current}/search-aggregations-metrics-boxplot-aggregation.html[Boxplot Aggregation]
	 */
	public class BoxplotAggregationUsageTests : AggregationUsageTestBase<ReadOnlyCluster>
	{
		public BoxplotAggregationUsageTests(ReadOnlyCluster i, EndpointUsage usage) : base(i, usage) { }

		protected override object AggregationJson => new
		{
			boxplot_commits = new
			{
				meta = new
				{
					foo = "bar"
				},
				boxplot = new
				{
					field = "numberOfCommits",
					missing = 10.0,
					compression = 100.0
				}
			}
		};

		protected override Func<AggregationContainerDescriptor<Project>, IAggregationContainer> FluentAggs => a => a
			.Boxplot("boxplot_commits", plot => plot
				.Meta(m => m
					.Add("foo", "bar")
				)
				.Field(p => p.NumberOfCommits)
				.Missing(10)
				.Compression(100)
			);

		protected override AggregationDictionary InitializerAggs =>
			new BoxplotAggregation("boxplot_commits", Field<Project>(p => p.NumberOfCommits))
			{
				Meta = new Dictionary<string, object>
				{
					{ "foo", "bar" }
				},
				Missing = 10,
				Compression = 100
			};

		protected override void ExpectResponse(ISearchResponse<Project> response)
		{
			response.ShouldBeValid();
			var boxplot = response.Aggregations.Boxplot("boxplot_commits");
			boxplot.Should().NotBeNull();
			boxplot.Min.Should().BeGreaterOrEqualTo(0);
			boxplot.Max.Should().BeGreaterOrEqualTo(0);
			boxplot.Q1.Should().BeGreaterOrEqualTo(0);
			boxplot.Q2.Should().BeGreaterOrEqualTo(0);
			boxplot.Q3.Should().BeGreaterOrEqualTo(0);
			boxplot.Lower.Should().BeGreaterOrEqualTo(0);
			boxplot.Upper.Should().BeGreaterOrEqualTo(0);
			boxplot.Meta.Should().NotBeNull().And.HaveCount(1);
			boxplot.Meta["foo"].Should().Be("bar");
		}
	}
}
