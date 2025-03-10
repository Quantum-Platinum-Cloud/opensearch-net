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
using OpenSearch.Net.Specification.CatApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace OpenSearch.Client
{
	///<summary>Descriptor for Aliases <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-aliases/</para></summary>
	public partial class CatAliasesDescriptor : RequestDescriptorBase<CatAliasesDescriptor, CatAliasesRequestParameters, ICatAliasesRequest>, ICatAliasesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatAliases;
		///<summary>/_cat/aliases</summary>
		public CatAliasesDescriptor(): base()
		{
		}

		///<summary>/_cat/aliases/{name}</summary>
		///<param name = "name">Optional, accepts null</param>
		public CatAliasesDescriptor(Names name): base(r => r.Optional("name", name))
		{
		}

		// values part of the url path
		Names ICatAliasesRequest.Name => Self.RouteValues.Get<Names>("name");
		///<summary>A comma-separated list of alias names to return</summary>
		public CatAliasesDescriptor Name(Names name) => Assign(name, (a, v) => a.RouteValues.Optional("name", v));
		// Request parameters
		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public CatAliasesDescriptor ExpandWildcards(ExpandWildcards? expandwildcards) => Qs("expand_wildcards", expandwildcards);
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatAliasesDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatAliasesDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatAliasesDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatAliasesDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatAliasesDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatAliasesDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Allocation <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-allocation/</para></summary>
	public partial class CatAllocationDescriptor : RequestDescriptorBase<CatAllocationDescriptor, CatAllocationRequestParameters, ICatAllocationRequest>, ICatAllocationRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatAllocation;
		///<summary>/_cat/allocation</summary>
		public CatAllocationDescriptor(): base()
		{
		}

		///<summary>/_cat/allocation/{node_id}</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		public CatAllocationDescriptor(NodeIds nodeId): base(r => r.Optional("node_id", nodeId))
		{
		}

		// values part of the url path
		NodeIds ICatAllocationRequest.NodeId => Self.RouteValues.Get<NodeIds>("node_id");
		///<summary>A comma-separated list of node IDs or names to limit the returned information</summary>
		public CatAllocationDescriptor NodeId(NodeIds nodeId) => Assign(nodeId, (a, v) => a.RouteValues.Optional("node_id", v));
		// Request parameters
		///<summary>The unit in which to display byte values</summary>
		public CatAllocationDescriptor Bytes(Bytes? bytes) => Qs("bytes", bytes);
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatAllocationDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatAllocationDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatAllocationDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatAllocationDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatAllocationDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatAllocationDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatAllocationDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatAllocationDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Count <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-count/</para></summary>
	public partial class CatCountDescriptor : RequestDescriptorBase<CatCountDescriptor, CatCountRequestParameters, ICatCountRequest>, ICatCountRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatCount;
		///<summary>/_cat/count</summary>
		public CatCountDescriptor(): base()
		{
		}

		///<summary>/_cat/count/{index}</summary>
		///<param name = "index">Optional, accepts null</param>
		public CatCountDescriptor(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		Indices ICatCountRequest.Index => Self.RouteValues.Get<Indices>("index");
		///<summary>A comma-separated list of index names to limit the returned information</summary>
		public CatCountDescriptor Index(Indices index) => Assign(index, (a, v) => a.RouteValues.Optional("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public CatCountDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Optional("index", (Indices)v));
		///<summary>A shortcut into calling Index(Indices.All)</summary>
		public CatCountDescriptor AllIndices() => Index(Indices.All);
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatCountDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatCountDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatCountDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatCountDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatCountDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Fielddata <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-field-data/</para></summary>
	public partial class CatFielddataDescriptor : RequestDescriptorBase<CatFielddataDescriptor, CatFielddataRequestParameters, ICatFielddataRequest>, ICatFielddataRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatFielddata;
		///<summary>/_cat/fielddata</summary>
		public CatFielddataDescriptor(): base()
		{
		}

		///<summary>/_cat/fielddata/{fields}</summary>
		///<param name = "fields">Optional, accepts null</param>
		public CatFielddataDescriptor(Fields fields): base(r => r.Optional("fields", fields))
		{
		}

		// values part of the url path
		Fields ICatFielddataRequest.Fields => Self.RouteValues.Get<Fields>("fields");
		///<summary>A comma-separated list of fields to return the fielddata size</summary>
		public CatFielddataDescriptor Fields(Fields fields) => Assign(fields, (a, v) => a.RouteValues.Optional("fields", v));
		///<summary>A comma-separated list of fields to return the fielddata size</summary>
		public CatFielddataDescriptor Fields<T>(params Expression<Func<T, object>>[] fields) => Assign(fields, (a, v) => a.RouteValues.Optional("fields", (Fields)v));
		// Request parameters
		///<summary>The unit in which to display byte values</summary>
		public CatFielddataDescriptor Bytes(Bytes? bytes) => Qs("bytes", bytes);
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatFielddataDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatFielddataDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatFielddataDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatFielddataDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatFielddataDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Health <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-health/</para></summary>
	public partial class CatHealthDescriptor : RequestDescriptorBase<CatHealthDescriptor, CatHealthRequestParameters, ICatHealthRequest>, ICatHealthRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatHealth;
		// values part of the url path
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatHealthDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatHealthDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatHealthDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Set to false to disable timestamping</summary>
		public CatHealthDescriptor IncludeTimestamp(bool? includetimestamp = true) => Qs("ts", includetimestamp);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatHealthDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatHealthDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Help <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/index/</para></summary>
	public partial class CatHelpDescriptor : RequestDescriptorBase<CatHelpDescriptor, CatHelpRequestParameters, ICatHelpRequest>, ICatHelpRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatHelp;
		// values part of the url path
		// Request parameters
		///<summary>Return help information</summary>
		public CatHelpDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatHelpDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
	}

	///<summary>Descriptor for Indices <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-indices/</para></summary>
	public partial class CatIndicesDescriptor : RequestDescriptorBase<CatIndicesDescriptor, CatIndicesRequestParameters, ICatIndicesRequest>, ICatIndicesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatIndices;
		///<summary>/_cat/indices</summary>
		public CatIndicesDescriptor(): base()
		{
		}

		///<summary>/_cat/indices/{index}</summary>
		///<param name = "index">Optional, accepts null</param>
		public CatIndicesDescriptor(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		Indices ICatIndicesRequest.Index => Self.RouteValues.Get<Indices>("index");
		///<summary>A comma-separated list of index names to limit the returned information</summary>
		public CatIndicesDescriptor Index(Indices index) => Assign(index, (a, v) => a.RouteValues.Optional("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public CatIndicesDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Optional("index", (Indices)v));
		///<summary>A shortcut into calling Index(Indices.All)</summary>
		public CatIndicesDescriptor AllIndices() => Index(Indices.All);
		// Request parameters
		///<summary>The unit in which to display byte values</summary>
		public CatIndicesDescriptor Bytes(Bytes? bytes) => Qs("bytes", bytes);
		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public CatIndicesDescriptor ExpandWildcards(ExpandWildcards? expandwildcards) => Qs("expand_wildcards", expandwildcards);
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatIndicesDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatIndicesDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>A health status ("green", "yellow", or "red" to filter only indices matching the specified health status</summary>
		public CatIndicesDescriptor Health(Health? health) => Qs("health", health);
		///<summary>Return help information</summary>
		public CatIndicesDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>If set to true segment stats will include stats for segments that are not currently loaded into memory</summary>
		public CatIndicesDescriptor IncludeUnloadedSegments(bool? includeunloadedsegments = true) => Qs("include_unloaded_segments", includeunloadedsegments);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatIndicesDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatIndicesDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatIndicesDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Set to true to return stats only for primary shards</summary>
		public CatIndicesDescriptor Pri(bool? pri = true) => Qs("pri", pri);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatIndicesDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatIndicesDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Master <para>https://opensearch.org/docs/1.2/opensearch/rest-api/cat/cat-master/</para></summary>
	///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="CatClusterManagerDescriptor"/> instead</remarks>
	public partial class CatMasterDescriptor : RequestDescriptorBase<CatMasterDescriptor, CatMasterRequestParameters, ICatMasterRequest>, ICatMasterRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMaster;
		// values part of the url path
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatMasterDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatMasterDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatMasterDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatMasterDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		public CatMasterDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatMasterDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatMasterDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Master <para>https://opensearch.org/docs/1.2/opensearch/rest-api/cat/cat-master/</para></summary>
	///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="CatMasterDescriptor"/></remarks>
	public partial class CatClusterManagerDescriptor : RequestDescriptorBase<CatClusterManagerDescriptor, CatClusterManagerRequestParameters, ICatClusterManagerRequest>, ICatClusterManagerRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatClusterManager;
		// values part of the url path
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatClusterManagerDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatClusterManagerDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatClusterManagerDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatClusterManagerDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		public CatClusterManagerDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatClusterManagerDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatClusterManagerDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for NodeAttributes <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodeattrs/</para></summary>
	public partial class CatNodeAttributesDescriptor : RequestDescriptorBase<CatNodeAttributesDescriptor, CatNodeAttributesRequestParameters, ICatNodeAttributesRequest>, ICatNodeAttributesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatNodeAttributes;
		// values part of the url path
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatNodeAttributesDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatNodeAttributesDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatNodeAttributesDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatNodeAttributesDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatNodeAttributesDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatNodeAttributesDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatNodeAttributesDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatNodeAttributesDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Nodes <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodes/</para></summary>
	public partial class CatNodesDescriptor : RequestDescriptorBase<CatNodesDescriptor, CatNodesRequestParameters, ICatNodesRequest>, ICatNodesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatNodes;
		// values part of the url path
		// Request parameters
		///<summary>The unit in which to display byte values</summary>
		public CatNodesDescriptor Bytes(Bytes? bytes) => Qs("bytes", bytes);
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatNodesDescriptor Format(string format) => Qs("format", format);
		///<summary>Return the full node ID instead of the shortened version (default: false)</summary>
		public CatNodesDescriptor FullId(bool? fullid = true) => Qs("full_id", fullid);
		///<summary>Comma-separated list of column names to display</summary>
		public CatNodesDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatNodesDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatNodesDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatNodesDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatNodesDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatNodesDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for PendingTasks <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-pending-tasks/</para></summary>
	public partial class CatPendingTasksDescriptor : RequestDescriptorBase<CatPendingTasksDescriptor, CatPendingTasksRequestParameters, ICatPendingTasksRequest>, ICatPendingTasksRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatPendingTasks;
		// values part of the url path
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatPendingTasksDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatPendingTasksDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatPendingTasksDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatPendingTasksDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatPendingTasksDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatPendingTasksDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatPendingTasksDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatPendingTasksDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Plugins <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-plugins/</para></summary>
	public partial class CatPluginsDescriptor : RequestDescriptorBase<CatPluginsDescriptor, CatPluginsRequestParameters, ICatPluginsRequest>, ICatPluginsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatPlugins;
		// values part of the url path
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatPluginsDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatPluginsDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatPluginsDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Include bootstrap plugins in the response</summary>
		public CatPluginsDescriptor IncludeBootstrap(bool? includebootstrap = true) => Qs("include_bootstrap", includebootstrap);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatPluginsDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatPluginsDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatPluginsDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatPluginsDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatPluginsDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Recovery <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-recovery/</para></summary>
	public partial class CatRecoveryDescriptor : RequestDescriptorBase<CatRecoveryDescriptor, CatRecoveryRequestParameters, ICatRecoveryRequest>, ICatRecoveryRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatRecovery;
		///<summary>/_cat/recovery</summary>
		public CatRecoveryDescriptor(): base()
		{
		}

		///<summary>/_cat/recovery/{index}</summary>
		///<param name = "index">Optional, accepts null</param>
		public CatRecoveryDescriptor(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		Indices ICatRecoveryRequest.Index => Self.RouteValues.Get<Indices>("index");
		///<summary>Comma-separated list or wildcard expression of index names to limit the returned information</summary>
		public CatRecoveryDescriptor Index(Indices index) => Assign(index, (a, v) => a.RouteValues.Optional("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public CatRecoveryDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Optional("index", (Indices)v));
		///<summary>A shortcut into calling Index(Indices.All)</summary>
		public CatRecoveryDescriptor AllIndices() => Index(Indices.All);
		// Request parameters
		///<summary>If `true`, the response only includes ongoing shard recoveries</summary>
		public CatRecoveryDescriptor ActiveOnly(bool? activeonly = true) => Qs("active_only", activeonly);
		///<summary>The unit in which to display byte values</summary>
		public CatRecoveryDescriptor Bytes(Bytes? bytes) => Qs("bytes", bytes);
		///<summary>If `true`, the response includes detailed information about shard recoveries</summary>
		public CatRecoveryDescriptor Detailed(bool? detailed = true) => Qs("detailed", detailed);
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatRecoveryDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatRecoveryDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatRecoveryDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatRecoveryDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatRecoveryDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Repositories <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-repositories/</para></summary>
	public partial class CatRepositoriesDescriptor : RequestDescriptorBase<CatRepositoriesDescriptor, CatRepositoriesRequestParameters, ICatRepositoriesRequest>, ICatRepositoriesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatRepositories;
		// values part of the url path
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatRepositoriesDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatRepositoriesDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatRepositoriesDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Return local information, do not retrieve the state from cluster_manager node</summary>
		public CatRepositoriesDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatRepositoriesDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatRepositoriesDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatRepositoriesDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatRepositoriesDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Segments <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/</para></summary>
	public partial class CatSegmentsDescriptor : RequestDescriptorBase<CatSegmentsDescriptor, CatSegmentsRequestParameters, ICatSegmentsRequest>, ICatSegmentsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatSegments;
		///<summary>/_cat/segments</summary>
		public CatSegmentsDescriptor(): base()
		{
		}

		///<summary>/_cat/segments/{index}</summary>
		///<param name = "index">Optional, accepts null</param>
		public CatSegmentsDescriptor(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		Indices ICatSegmentsRequest.Index => Self.RouteValues.Get<Indices>("index");
		///<summary>A comma-separated list of index names to limit the returned information</summary>
		public CatSegmentsDescriptor Index(Indices index) => Assign(index, (a, v) => a.RouteValues.Optional("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public CatSegmentsDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Optional("index", (Indices)v));
		///<summary>A shortcut into calling Index(Indices.All)</summary>
		public CatSegmentsDescriptor AllIndices() => Index(Indices.All);
		// Request parameters
		///<summary>The unit in which to display byte values</summary>
		public CatSegmentsDescriptor Bytes(Bytes? bytes) => Qs("bytes", bytes);
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatSegmentsDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatSegmentsDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatSegmentsDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatSegmentsDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatSegmentsDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Shards <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-shards/</para></summary>
	public partial class CatShardsDescriptor : RequestDescriptorBase<CatShardsDescriptor, CatShardsRequestParameters, ICatShardsRequest>, ICatShardsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatShards;
		///<summary>/_cat/shards</summary>
		public CatShardsDescriptor(): base()
		{
		}

		///<summary>/_cat/shards/{index}</summary>
		///<param name = "index">Optional, accepts null</param>
		public CatShardsDescriptor(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		Indices ICatShardsRequest.Index => Self.RouteValues.Get<Indices>("index");
		///<summary>A comma-separated list of index names to limit the returned information</summary>
		public CatShardsDescriptor Index(Indices index) => Assign(index, (a, v) => a.RouteValues.Optional("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public CatShardsDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Optional("index", (Indices)v));
		///<summary>A shortcut into calling Index(Indices.All)</summary>
		public CatShardsDescriptor AllIndices() => Index(Indices.All);
		// Request parameters
		///<summary>The unit in which to display byte values</summary>
		public CatShardsDescriptor Bytes(Bytes? bytes) => Qs("bytes", bytes);
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatShardsDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatShardsDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatShardsDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatShardsDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatShardsDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatShardsDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatShardsDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatShardsDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Snapshots <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</para></summary>
	public partial class CatSnapshotsDescriptor : RequestDescriptorBase<CatSnapshotsDescriptor, CatSnapshotsRequestParameters, ICatSnapshotsRequest>, ICatSnapshotsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatSnapshots;
		///<summary>/_cat/snapshots</summary>
		public CatSnapshotsDescriptor(): base()
		{
		}

		///<summary>/_cat/snapshots/{repository}</summary>
		///<param name = "repository">Optional, accepts null</param>
		public CatSnapshotsDescriptor(Names repository): base(r => r.Optional("repository", repository))
		{
		}

		// values part of the url path
		Names ICatSnapshotsRequest.RepositoryName => Self.RouteValues.Get<Names>("repository");
		///<summary>Name of repository from which to fetch the snapshot information</summary>
		public CatSnapshotsDescriptor RepositoryName(Names repository) => Assign(repository, (a, v) => a.RouteValues.Optional("repository", v));
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatSnapshotsDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatSnapshotsDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatSnapshotsDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Set to true to ignore unavailable snapshots</summary>
		public CatSnapshotsDescriptor IgnoreUnavailable(bool? ignoreunavailable = true) => Qs("ignore_unavailable", ignoreunavailable);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatSnapshotsDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatSnapshotsDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatSnapshotsDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatSnapshotsDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Tasks <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
	public partial class CatTasksDescriptor : RequestDescriptorBase<CatTasksDescriptor, CatTasksRequestParameters, ICatTasksRequest>, ICatTasksRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatTasks;
		// values part of the url path
		// Request parameters
		///<summary>A comma-separated list of actions that should be returned. Leave empty to return all.</summary>
		public CatTasksDescriptor Actions(params string[] actions) => Qs("actions", actions);
		///<summary>Return detailed task information (default: false)</summary>
		public CatTasksDescriptor Detailed(bool? detailed = true) => Qs("detailed", detailed);
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatTasksDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatTasksDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatTasksDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</summary>
		public CatTasksDescriptor Nodes(params string[] nodes) => Qs("nodes", nodes);
		///<summary>Return tasks with specified parent task id (node_id:task_number). Set to -1 to return all.</summary>
		public CatTasksDescriptor ParentTaskId(string parenttaskid) => Qs("parent_task_id", parenttaskid);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatTasksDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatTasksDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for Templates <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
	public partial class CatTemplatesDescriptor : RequestDescriptorBase<CatTemplatesDescriptor, CatTemplatesRequestParameters, ICatTemplatesRequest>, ICatTemplatesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatTemplates;
		///<summary>/_cat/templates</summary>
		public CatTemplatesDescriptor(): base()
		{
		}

		///<summary>/_cat/templates/{name}</summary>
		///<param name = "name">Optional, accepts null</param>
		public CatTemplatesDescriptor(Name name): base(r => r.Optional("name", name))
		{
		}

		// values part of the url path
		Name ICatTemplatesRequest.Name => Self.RouteValues.Get<Name>("name");
		///<summary>A pattern that returned template names must match</summary>
		public CatTemplatesDescriptor Name(Name name) => Assign(name, (a, v) => a.RouteValues.Optional("name", v));
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatTemplatesDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatTemplatesDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatTemplatesDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatTemplatesDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatTemplatesDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatTemplatesDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatTemplatesDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatTemplatesDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}

	///<summary>Descriptor for ThreadPool <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-thread-pool/</para></summary>
	public partial class CatThreadPoolDescriptor : RequestDescriptorBase<CatThreadPoolDescriptor, CatThreadPoolRequestParameters, ICatThreadPoolRequest>, ICatThreadPoolRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatThreadPool;
		///<summary>/_cat/thread_pool</summary>
		public CatThreadPoolDescriptor(): base()
		{
		}

		///<summary>/_cat/thread_pool/{thread_pool_patterns}</summary>
		///<param name = "threadPoolPatterns">Optional, accepts null</param>
		public CatThreadPoolDescriptor(Names threadPoolPatterns): base(r => r.Optional("thread_pool_patterns", threadPoolPatterns))
		{
		}

		// values part of the url path
		Names ICatThreadPoolRequest.ThreadPoolPatterns => Self.RouteValues.Get<Names>("thread_pool_patterns");
		///<summary>A comma-separated list of regular-expressions to filter the thread pools in the output</summary>
		public CatThreadPoolDescriptor ThreadPoolPatterns(Names threadPoolPatterns) => Assign(threadPoolPatterns, (a, v) => a.RouteValues.Optional("thread_pool_patterns", v));
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatThreadPoolDescriptor Format(string format) => Qs("format", format);
		///<summary>Comma-separated list of column names to display</summary>
		public CatThreadPoolDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatThreadPoolDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public CatThreadPoolDescriptor Local(bool? local = true) => Qs("local", local);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public CatThreadPoolDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public CatThreadPoolDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatThreadPoolDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatThreadPoolDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
	}
}
