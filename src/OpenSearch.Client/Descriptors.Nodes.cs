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
using OpenSearch.Net;
using OpenSearch.Net.Utf8Json;
using OpenSearch.Net.Specification.NodesApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace OpenSearch.Client
{
	///<summary>Descriptor for HotThreads <para></para></summary>
	public partial class NodesHotThreadsDescriptor : RequestDescriptorBase<NodesHotThreadsDescriptor, NodesHotThreadsRequestParameters, INodesHotThreadsRequest>, INodesHotThreadsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesHotThreads;
		///<summary>/_nodes/hot_threads</summary>
		public NodesHotThreadsDescriptor(): base()
		{
		}

		///<summary>/_nodes/{node_id}/hot_threads</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		public NodesHotThreadsDescriptor(NodeIds nodeId): base(r => r.Optional("node_id", nodeId))
		{
		}

		// values part of the url path
		NodeIds INodesHotThreadsRequest.NodeId => Self.RouteValues.Get<NodeIds>("node_id");
		///<summary>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</summary>
		public NodesHotThreadsDescriptor NodeId(NodeIds nodeId) => Assign(nodeId, (a, v) => a.RouteValues.Optional("node_id", v));
		// Request parameters
		///<summary>Don't show threads that are in known-idle places, such as waiting on a socket select or pulling from an empty task queue (default: true)</summary>
		public NodesHotThreadsDescriptor IgnoreIdleThreads(bool? ignoreidlethreads = true) => Qs("ignore_idle_threads", ignoreidlethreads);
		///<summary>The interval for the second sampling of threads</summary>
		public NodesHotThreadsDescriptor Interval(Time interval) => Qs("interval", interval);
		///<summary>Number of samples of thread stacktrace (default: 10)</summary>
		public NodesHotThreadsDescriptor Snapshots(long? snapshots) => Qs("snapshots", snapshots);
		///<summary>The type to sample (default: cpu)</summary>
		public NodesHotThreadsDescriptor ThreadType(ThreadType? threadtype) => Qs("type", threadtype);
		///<summary>Specify the number of threads to provide information for (default: 3)</summary>
		public NodesHotThreadsDescriptor Threads(long? threads) => Qs("threads", threads);
		///<summary>Explicit operation timeout</summary>
		public NodesHotThreadsDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
	}

	///<summary>Descriptor for Info <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodes/</para></summary>
	public partial class NodesInfoDescriptor : RequestDescriptorBase<NodesInfoDescriptor, NodesInfoRequestParameters, INodesInfoRequest>, INodesInfoRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesInfo;
		///<summary>/_nodes</summary>
		public NodesInfoDescriptor(): base()
		{
		}

		///<summary>/_nodes/{node_id}</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		public NodesInfoDescriptor(NodeIds nodeId): base(r => r.Optional("node_id", nodeId))
		{
		}

		///<summary>/_nodes/{metric}</summary>
		///<param name = "metric">Optional, accepts null</param>
		public NodesInfoDescriptor(Metrics metric): base(r => r.Optional("metric", metric))
		{
		}

		///<summary>/_nodes/{node_id}/{metric}</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		///<param name = "metric">Optional, accepts null</param>
		public NodesInfoDescriptor(NodeIds nodeId, Metrics metric): base(r => r.Optional("node_id", nodeId).Optional("metric", metric))
		{
		}

		// values part of the url path
		NodeIds INodesInfoRequest.NodeId => Self.RouteValues.Get<NodeIds>("node_id");
		Metrics INodesInfoRequest.Metric => Self.RouteValues.Get<Metrics>("metric");
		///<summary>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</summary>
		public NodesInfoDescriptor NodeId(NodeIds nodeId) => Assign(nodeId, (a, v) => a.RouteValues.Optional("node_id", v));
		///<summary>A comma-separated list of metrics you wish returned. Leave empty to return all.</summary>
		public NodesInfoDescriptor Metric(Metrics metric) => Assign(metric, (a, v) => a.RouteValues.Optional("metric", v));
		// Request parameters
		///<summary>Return settings in flat format (default: false)</summary>
		public NodesInfoDescriptor FlatSettings(bool? flatsettings = true) => Qs("flat_settings", flatsettings);
		///<summary>Explicit operation timeout</summary>
		public NodesInfoDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
	}

	///<summary>Descriptor for ReloadSecureSettings <para></para></summary>
	public partial class ReloadSecureSettingsDescriptor : RequestDescriptorBase<ReloadSecureSettingsDescriptor, ReloadSecureSettingsRequestParameters, IReloadSecureSettingsRequest>, IReloadSecureSettingsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesReloadSecureSettings;
		///<summary>/_nodes/reload_secure_settings</summary>
		public ReloadSecureSettingsDescriptor(): base()
		{
		}

		///<summary>/_nodes/{node_id}/reload_secure_settings</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		public ReloadSecureSettingsDescriptor(NodeIds nodeId): base(r => r.Optional("node_id", nodeId))
		{
		}

		// values part of the url path
		NodeIds IReloadSecureSettingsRequest.NodeId => Self.RouteValues.Get<NodeIds>("node_id");
		///<summary>A comma-separated list of node IDs to span the reload/reinit call. Should stay empty because reloading usually involves all cluster nodes.</summary>
		public ReloadSecureSettingsDescriptor NodeId(NodeIds nodeId) => Assign(nodeId, (a, v) => a.RouteValues.Optional("node_id", v));
		// Request parameters
		///<summary>Explicit operation timeout</summary>
		public ReloadSecureSettingsDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
	}

	///<summary>Descriptor for Stats <para>https://opensearch.org/docs/latest/opensearch/stats-api/</para></summary>
	public partial class NodesStatsDescriptor : RequestDescriptorBase<NodesStatsDescriptor, NodesStatsRequestParameters, INodesStatsRequest>, INodesStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesStats;
		///<summary>/_nodes/stats</summary>
		public NodesStatsDescriptor(): base()
		{
		}

		///<summary>/_nodes/{node_id}/stats</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		public NodesStatsDescriptor(NodeIds nodeId): base(r => r.Optional("node_id", nodeId))
		{
		}

		///<summary>/_nodes/stats/{metric}</summary>
		///<param name = "metric">Optional, accepts null</param>
		public NodesStatsDescriptor(Metrics metric): base(r => r.Optional("metric", metric))
		{
		}

		///<summary>/_nodes/{node_id}/stats/{metric}</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		///<param name = "metric">Optional, accepts null</param>
		public NodesStatsDescriptor(NodeIds nodeId, Metrics metric): base(r => r.Optional("node_id", nodeId).Optional("metric", metric))
		{
		}

		///<summary>/_nodes/stats/{metric}/{index_metric}</summary>
		///<param name = "metric">Optional, accepts null</param>
		///<param name = "indexMetric">Optional, accepts null</param>
		public NodesStatsDescriptor(Metrics metric, IndexMetrics indexMetric): base(r => r.Optional("metric", metric).Optional("index_metric", indexMetric))
		{
		}

		///<summary>/_nodes/{node_id}/stats/{metric}/{index_metric}</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		///<param name = "metric">Optional, accepts null</param>
		///<param name = "indexMetric">Optional, accepts null</param>
		public NodesStatsDescriptor(NodeIds nodeId, Metrics metric, IndexMetrics indexMetric): base(r => r.Optional("node_id", nodeId).Optional("metric", metric).Optional("index_metric", indexMetric))
		{
		}

		// values part of the url path
		NodeIds INodesStatsRequest.NodeId => Self.RouteValues.Get<NodeIds>("node_id");
		Metrics INodesStatsRequest.Metric => Self.RouteValues.Get<Metrics>("metric");
		IndexMetrics INodesStatsRequest.IndexMetric => Self.RouteValues.Get<IndexMetrics>("index_metric");
		///<summary>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</summary>
		public NodesStatsDescriptor NodeId(NodeIds nodeId) => Assign(nodeId, (a, v) => a.RouteValues.Optional("node_id", v));
		///<summary>Limit the information returned to the specified metrics</summary>
		public NodesStatsDescriptor Metric(Metrics metric) => Assign(metric, (a, v) => a.RouteValues.Optional("metric", v));
		///<summary>Limit the information returned for `indices` metric to the specific index metrics. Isn't used if `indices` (or `all`) metric isn't specified.</summary>
		public NodesStatsDescriptor IndexMetric(IndexMetrics indexMetric) => Assign(indexMetric, (a, v) => a.RouteValues.Optional("index_metric", v));
		// Request parameters
		///<summary>A comma-separated list of fields for `fielddata` and `suggest` index metric (supports wildcards)</summary>
		public NodesStatsDescriptor CompletionFields(Fields completionfields) => Qs("completion_fields", completionfields);
		///<summary>A comma-separated list of fields for `fielddata` and `suggest` index metric (supports wildcards)</summary>
		public NodesStatsDescriptor CompletionFields<T>(params Expression<Func<T, object>>[] fields)
			where T : class => Qs("completion_fields", fields?.Select(e => (Field)e));
		///<summary>A comma-separated list of fields for `fielddata` index metric (supports wildcards)</summary>
		public NodesStatsDescriptor FielddataFields(Fields fielddatafields) => Qs("fielddata_fields", fielddatafields);
		///<summary>A comma-separated list of fields for `fielddata` index metric (supports wildcards)</summary>
		public NodesStatsDescriptor FielddataFields<T>(params Expression<Func<T, object>>[] fields)
			where T : class => Qs("fielddata_fields", fields?.Select(e => (Field)e));
		///<summary>A comma-separated list of fields for `fielddata` and `completion` index metric (supports wildcards)</summary>
		public NodesStatsDescriptor Fields(Fields fields) => Qs("fields", fields);
		///<summary>A comma-separated list of fields for `fielddata` and `completion` index metric (supports wildcards)</summary>
		public NodesStatsDescriptor Fields<T>(params Expression<Func<T, object>>[] fields)
			where T : class => Qs("fields", fields?.Select(e => (Field)e));
		///<summary>A comma-separated list of search groups for `search` index metric</summary>
		public NodesStatsDescriptor Groups(bool? groups = true) => Qs("groups", groups);
		///<summary>Whether to report the aggregated disk usage of each one of the Lucene index files (only applies if segment stats are requested)</summary>
		public NodesStatsDescriptor IncludeSegmentFileSizes(bool? includesegmentfilesizes = true) => Qs("include_segment_file_sizes", includesegmentfilesizes);
		///<summary>Return indices stats aggregated at index, node or shard level</summary>
		public NodesStatsDescriptor Level(Level? level) => Qs("level", level);
		///<summary>Explicit operation timeout</summary>
		public NodesStatsDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
		///<summary>A comma-separated list of document types for the `indexing` index metric</summary>
		public NodesStatsDescriptor Types(params string[] types) => Qs("types", types);
	}

	///<summary>Descriptor for Usage <para></para></summary>
	public partial class NodesUsageDescriptor : RequestDescriptorBase<NodesUsageDescriptor, NodesUsageRequestParameters, INodesUsageRequest>, INodesUsageRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesUsage;
		///<summary>/_nodes/usage</summary>
		public NodesUsageDescriptor(): base()
		{
		}

		///<summary>/_nodes/{node_id}/usage</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		public NodesUsageDescriptor(NodeIds nodeId): base(r => r.Optional("node_id", nodeId))
		{
		}

		///<summary>/_nodes/usage/{metric}</summary>
		///<param name = "metric">Optional, accepts null</param>
		public NodesUsageDescriptor(Metrics metric): base(r => r.Optional("metric", metric))
		{
		}

		///<summary>/_nodes/{node_id}/usage/{metric}</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		///<param name = "metric">Optional, accepts null</param>
		public NodesUsageDescriptor(NodeIds nodeId, Metrics metric): base(r => r.Optional("node_id", nodeId).Optional("metric", metric))
		{
		}

		// values part of the url path
		NodeIds INodesUsageRequest.NodeId => Self.RouteValues.Get<NodeIds>("node_id");
		Metrics INodesUsageRequest.Metric => Self.RouteValues.Get<Metrics>("metric");
		///<summary>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</summary>
		public NodesUsageDescriptor NodeId(NodeIds nodeId) => Assign(nodeId, (a, v) => a.RouteValues.Optional("node_id", v));
		///<summary>Limit the information returned to the specified metrics</summary>
		public NodesUsageDescriptor Metric(Metrics metric) => Assign(metric, (a, v) => a.RouteValues.Optional("metric", v));
		// Request parameters
		///<summary>Explicit operation timeout</summary>
		public NodesUsageDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
	}
}
