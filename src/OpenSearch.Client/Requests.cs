/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*/
/*
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

// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using OpenSearch.Net;
using OpenSearch.Net.Utf8Json;
using OpenSearch.Net.Specification.CatApi;
using OpenSearch.Net.Specification.ClusterApi;
using OpenSearch.Net.Specification.DanglingIndicesApi;
using OpenSearch.Net.Specification.IndicesApi;
using OpenSearch.Net.Specification.IngestApi;
using OpenSearch.Net.Specification.NodesApi;
using OpenSearch.Net.Specification.SnapshotApi;
using OpenSearch.Net.Specification.TasksApi;

// ReSharper disable UnusedTypeParameter
namespace OpenSearch.Client
{
	public abstract partial class PlainRequestBase<TParameters>
	{
		///<summary>Include the stack trace of returned errors.</summary>
		public bool? ErrorTrace
		{
			get => Q<bool? >("error_trace");
			set => Q("error_trace", value);
		}

		///<summary>
		/// A comma-separated list of filters used to reduce the response.
		/// <para>Use of response filtering can result in a response from OpenSearch
		/// that cannot be correctly deserialized to the respective response type for the request.
		/// In such situations, use the low level client to issue the request and handle response deserialization</para>
		///</summary>
		public string[] FilterPath
		{
			get => Q<string[]>("filter_path");
			set => Q("filter_path", value);
		}

		///<summary>Return human readable values for statistics.</summary>
		public bool? Human
		{
			get => Q<bool? >("human");
			set => Q("human", value);
		}

		///<summary>Pretty format the returned JSON response.</summary>
		public bool? Pretty
		{
			get => Q<bool? >("pretty");
			set => Q("pretty", value);
		}

		///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
		public string SourceQueryString
		{
			get => Q<string>("source");
			set => Q("source", value);
		}
	}
}
