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
using OpenSearch.Net.Specification.IndicesApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace OpenSearch.Client
{
	[InterfaceDataContract]
	public partial interface IAddIndexBlockRequest : IRequest<AddIndexBlockRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}

		[IgnoreDataMember]
		IndexBlock Block
		{
			get;
		}
	}

	///<summary>Request for AddBlock <para></para></summary>
	public partial class AddIndexBlockRequest : PlainRequestBase<AddIndexBlockRequestParameters>, IAddIndexBlockRequest
	{
		protected IAddIndexBlockRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesAddBlock;
		///<summary>/{index}/_block/{block}</summary>
		///<param name = "index">this parameter is required</param>
		///<param name = "block">this parameter is required</param>
		public AddIndexBlockRequest(Indices index, IndexBlock block): base(r => r.Required("index", index).Required("block", block))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected AddIndexBlockRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IAddIndexBlockRequest.Index => Self.RouteValues.Get<Indices>("index");
		[IgnoreDataMember]
		IndexBlock IAddIndexBlockRequest.Block => Self.RouteValues.Get<IndexBlock>("block");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IAnalyzeRequest : IRequest<AnalyzeRequestParameters>
	{
		[IgnoreDataMember]
		IndexName Index
		{
			get;
		}
	}

	///<summary>Request for Analyze <para></para></summary>
	public partial class AnalyzeRequest : PlainRequestBase<AnalyzeRequestParameters>, IAnalyzeRequest
	{
		protected IAnalyzeRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesAnalyze;
		///<summary>/_analyze</summary>
		public AnalyzeRequest(): base()
		{
		}

		///<summary>/{index}/_analyze</summary>
		///<param name = "index">Optional, accepts null</param>
		public AnalyzeRequest(IndexName index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		IndexName IAnalyzeRequest.Index => Self.RouteValues.Get<IndexName>("index");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IClearCacheRequest : IRequest<ClearCacheRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for ClearCache <para></para></summary>
	public partial class ClearCacheRequest : PlainRequestBase<ClearCacheRequestParameters>, IClearCacheRequest
	{
		protected IClearCacheRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesClearCache;
		///<summary>/_cache/clear</summary>
		public ClearCacheRequest(): base()
		{
		}

		///<summary>/{index}/_cache/clear</summary>
		///<param name = "index">Optional, accepts null</param>
		public ClearCacheRequest(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IClearCacheRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Clear field data</summary>
		public bool? Fielddata
		{
			get => Q<bool? >("fielddata");
			set => Q("fielddata", value);
		}

		///<summary>A comma-separated list of fields to clear when using the `fielddata` parameter (default: all)</summary>
		public Fields Fields
		{
			get => Q<Fields>("fields");
			set => Q("fields", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Clear query caches</summary>
		public bool? Query
		{
			get => Q<bool? >("query");
			set => Q("query", value);
		}

		///<summary>Clear request cache</summary>
		public bool? Request
		{
			get => Q<bool? >("request");
			set => Q("request", value);
		}
	}

	[InterfaceDataContract]
	public partial interface ICloneIndexRequest : IRequest<CloneIndexRequestParameters>
	{
		[IgnoreDataMember]
		IndexName Index
		{
			get;
		}

		[IgnoreDataMember]
		IndexName Target
		{
			get;
		}
	}

	///<summary>Request for Clone <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/clone/</para></summary>
	public partial class CloneIndexRequest : PlainRequestBase<CloneIndexRequestParameters>, ICloneIndexRequest
	{
		protected ICloneIndexRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesClone;
		///<summary>/{index}/_clone/{target}</summary>
		///<param name = "index">this parameter is required</param>
		///<param name = "target">this parameter is required</param>
		public CloneIndexRequest(IndexName index, IndexName target): base(r => r.Required("index", index).Required("target", target))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected CloneIndexRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		IndexName ICloneIndexRequest.Index => Self.RouteValues.Get<IndexName>("index");
		[IgnoreDataMember]
		IndexName ICloneIndexRequest.Target => Self.RouteValues.Get<IndexName>("target");
		// Request parameters
		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Set the number of active shards to wait for on the cloned index before the operation returns.</summary>
		public string WaitForActiveShards
		{
			get => Q<string>("wait_for_active_shards");
			set => Q("wait_for_active_shards", value);
		}
	}

	[InterfaceDataContract]
	public partial interface ICloseIndexRequest : IRequest<CloseIndexRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for Close <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/close-index/</para></summary>
	public partial class CloseIndexRequest : PlainRequestBase<CloseIndexRequestParameters>, ICloseIndexRequest
	{
		protected ICloseIndexRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesClose;
		///<summary>/{index}/_close</summary>
		///<param name = "index">this parameter is required</param>
		public CloseIndexRequest(Indices index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected CloseIndexRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices ICloseIndexRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Sets the number of active shards to wait for before the operation returns.</summary>
		public string WaitForActiveShards
		{
			get => Q<string>("wait_for_active_shards");
			set => Q("wait_for_active_shards", value);
		}
	}

	[InterfaceDataContract]
	public partial interface ICreateIndexRequest : IRequest<CreateIndexRequestParameters>
	{
		[IgnoreDataMember]
		IndexName Index
		{
			get;
		}
	}

	///<summary>Request for Create <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/create-index/</para></summary>
	public partial class CreateIndexRequest : PlainRequestBase<CreateIndexRequestParameters>, ICreateIndexRequest
	{
		protected ICreateIndexRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesCreate;
		///<summary>/{index}</summary>
		///<param name = "index">this parameter is required</param>
		public CreateIndexRequest(IndexName index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected CreateIndexRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		IndexName ICreateIndexRequest.Index => Self.RouteValues.Get<IndexName>("index");
		// Request parameters
		///<summary>Whether a type should be expected in the body of the mappings.</summary>
		///<remarks>Deprecated as of OpenSearch 2.0</remarks>
		public bool? IncludeTypeName
		{
			get => Q<bool? >("include_type_name");
			set => Q("include_type_name", value);
		}

		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Set the number of active shards to wait for before the operation returns.</summary>
		public string WaitForActiveShards
		{
			get => Q<string>("wait_for_active_shards");
			set => Q("wait_for_active_shards", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IDeleteIndexRequest : IRequest<DeleteIndexRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for Delete <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/delete-index/</para></summary>
	public partial class DeleteIndexRequest : PlainRequestBase<DeleteIndexRequestParameters>, IDeleteIndexRequest
	{
		protected IDeleteIndexRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesDelete;
		///<summary>/{index}</summary>
		///<param name = "index">this parameter is required</param>
		public DeleteIndexRequest(Indices index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteIndexRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IDeleteIndexRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>Ignore if a wildcard expression resolves to no concrete indices (default: false)</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether wildcard expressions should get expanded to open or closed indices (default: open)</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Ignore unavailable indexes (default: false)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}
		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IDeleteAliasRequest : IRequest<DeleteAliasRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}

		[IgnoreDataMember]
		Names Name
		{
			get;
		}
	}

	///<summary>Request for DeleteAlias <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
	public partial class DeleteAliasRequest : PlainRequestBase<DeleteAliasRequestParameters>, IDeleteAliasRequest
	{
		protected IDeleteAliasRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesDeleteAlias;
		///<summary>/{index}/_alias/{name}</summary>
		///<param name = "index">this parameter is required</param>
		///<param name = "name">this parameter is required</param>
		public DeleteAliasRequest(Indices index, Names name): base(r => r.Required("index", index).Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteAliasRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IDeleteAliasRequest.Index => Self.RouteValues.Get<Indices>("index");
		[IgnoreDataMember]
		Names IDeleteAliasRequest.Name => Self.RouteValues.Get<Names>("name");
		// Request parameters
		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit timestamp for the document</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IDeleteIndexTemplateRequest : IRequest<DeleteIndexTemplateRequestParameters>
	{
		[IgnoreDataMember]
		Name Name
		{
			get;
		}
	}

	///<summary>Request for DeleteTemplate <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
	public partial class DeleteIndexTemplateRequest : PlainRequestBase<DeleteIndexTemplateRequestParameters>, IDeleteIndexTemplateRequest
	{
		protected IDeleteIndexTemplateRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesDeleteTemplate;
		///<summary>/_template/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public DeleteIndexTemplateRequest(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteIndexTemplateRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IDeleteIndexTemplateRequest.Name => Self.RouteValues.Get<Name>("name");
		// Request parameters
		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IIndexExistsRequest : IRequest<IndexExistsRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for Exists <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/exists/</para></summary>
	public partial class IndexExistsRequest : PlainRequestBase<IndexExistsRequestParameters>, IIndexExistsRequest
	{
		protected IIndexExistsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesExists;
		///<summary>/{index}</summary>
		///<param name = "index">this parameter is required</param>
		public IndexExistsRequest(Indices index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected IndexExistsRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IIndexExistsRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>Ignore if a wildcard expression resolves to no concrete indices (default: false)</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether wildcard expressions should get expanded to open or closed indices (default: open)</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Return settings in flat format (default: false)</summary>
		public bool? FlatSettings
		{
			get => Q<bool? >("flat_settings");
			set => Q("flat_settings", value);
		}

		///<summary>Ignore unavailable indexes (default: false)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Whether to return all default setting for each of the indices.</summary>
		public bool? IncludeDefaults
		{
			get => Q<bool? >("include_defaults");
			set => Q("include_defaults", value);
		}

		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public bool? Local
		{
			get => Q<bool? >("local");
			set => Q("local", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IAliasExistsRequest : IRequest<AliasExistsRequestParameters>
	{
		[IgnoreDataMember]
		Names Name
		{
			get;
		}

		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for AliasExists <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
	public partial class AliasExistsRequest : PlainRequestBase<AliasExistsRequestParameters>, IAliasExistsRequest
	{
		protected IAliasExistsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesAliasExists;
		///<summary>/_alias/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public AliasExistsRequest(Names name): base(r => r.Required("name", name))
		{
		}

		///<summary>/{index}/_alias/{name}</summary>
		///<param name = "index">Optional, accepts null</param>
		///<param name = "name">this parameter is required</param>
		public AliasExistsRequest(Indices index, Names name): base(r => r.Optional("index", index).Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected AliasExistsRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Names IAliasExistsRequest.Name => Self.RouteValues.Get<Names>("name");
		[IgnoreDataMember]
		Indices IAliasExistsRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public bool? Local
		{
			get => Q<bool? >("local");
			set => Q("local", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IIndexTemplateExistsRequest : IRequest<IndexTemplateExistsRequestParameters>
	{
		[IgnoreDataMember]
		Names Name
		{
			get;
		}
	}

	///<summary>Request for TemplateExists <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
	public partial class IndexTemplateExistsRequest : PlainRequestBase<IndexTemplateExistsRequestParameters>, IIndexTemplateExistsRequest
	{
		protected IIndexTemplateExistsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesTemplateExists;
		///<summary>/_template/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public IndexTemplateExistsRequest(Names name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected IndexTemplateExistsRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Names IIndexTemplateExistsRequest.Name => Self.RouteValues.Get<Names>("name");
		// Request parameters
		///<summary>Return settings in flat format (default: false)</summary>
		public bool? FlatSettings
		{
			get => Q<bool? >("flat_settings");
			set => Q("flat_settings", value);
		}

		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public bool? Local
		{
			get => Q<bool? >("local");
			set => Q("local", value);
		}

		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}
	}

	/// <remarks>Deprecated as of OpenSearch 2.0</remarks>
	[InterfaceDataContract]
	public partial interface ITypeExistsRequest : IRequest<TypeExistsRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}

		[IgnoreDataMember]
		Names Type
		{
			get;
		}
	}

	///<summary>Request for TypeExists <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/exists/</para></summary>
	///<remarks>Deprecated as of OpenSearch 2.0</remarks>
	public partial class TypeExistsRequest : PlainRequestBase<TypeExistsRequestParameters>, ITypeExistsRequest
	{
		protected ITypeExistsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesTypeExists;
		///<summary>/{index}/_mapping/{type}</summary>
		///<param name = "index">this parameter is required</param>
		///<param name = "type">this parameter is required</param>
		public TypeExistsRequest(Indices index, Names type): base(r => r.Required("index", index).Required("type", type))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected TypeExistsRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices ITypeExistsRequest.Index => Self.RouteValues.Get<Indices>("index");
		[IgnoreDataMember]
		Names ITypeExistsRequest.Type => Self.RouteValues.Get<Names>("type");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public bool? Local
		{
			get => Q<bool? >("local");
			set => Q("local", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IFlushRequest : IRequest<FlushRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for Flush <para></para></summary>
	public partial class FlushRequest : PlainRequestBase<FlushRequestParameters>, IFlushRequest
	{
		protected IFlushRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesFlush;
		///<summary>/_flush</summary>
		public FlushRequest(): base()
		{
		}

		///<summary>/{index}/_flush</summary>
		///<param name = "index">Optional, accepts null</param>
		public FlushRequest(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IFlushRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>
		/// Whether a flush should be forced even if it is not necessarily needed ie. if no changes will be committed to the index. This is useful if
		/// transaction log IDs should be incremented even if no uncommitted changes are present. (This setting can be considered as internal)
		///</summary>
		public bool? Force
		{
			get => Q<bool? >("force");
			set => Q("force", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>
		/// If set to true the flush operation will block until the flush can be executed if another flush operation is already executing. The default
		/// is true. If set to false the flush will be skipped iff if another flush operation is already running.
		///</summary>
		public bool? WaitIfOngoing
		{
			get => Q<bool? >("wait_if_ongoing");
			set => Q("wait_if_ongoing", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IForceMergeRequest : IRequest<ForceMergeRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for ForceMerge <para></para></summary>
	public partial class ForceMergeRequest : PlainRequestBase<ForceMergeRequestParameters>, IForceMergeRequest
	{
		protected IForceMergeRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesForceMerge;
		///<summary>/_forcemerge</summary>
		public ForceMergeRequest(): base()
		{
		}

		///<summary>/{index}/_forcemerge</summary>
		///<param name = "index">Optional, accepts null</param>
		public ForceMergeRequest(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IForceMergeRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Specify whether the index should be flushed after performing the operation (default: true)</summary>
		public bool? Flush
		{
			get => Q<bool? >("flush");
			set => Q("flush", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>The number of segments the index should be merged into (default: dynamic)</summary>
		public long? MaxNumSegments
		{
			get => Q<long? >("max_num_segments");
			set => Q("max_num_segments", value);
		}

		///<summary>Specify whether the operation should only expunge deleted documents</summary>
		public bool? OnlyExpungeDeletes
		{
			get => Q<bool? >("only_expunge_deletes");
			set => Q("only_expunge_deletes", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetIndexRequest : IRequest<GetIndexRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for Get <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/get-index/</para></summary>
	public partial class GetIndexRequest : PlainRequestBase<GetIndexRequestParameters>, IGetIndexRequest
	{
		protected IGetIndexRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesGet;
		///<summary>/{index}</summary>
		///<param name = "index">this parameter is required</param>
		public GetIndexRequest(Indices index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected GetIndexRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IGetIndexRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>Ignore if a wildcard expression resolves to no concrete indices (default: false)</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether wildcard expressions should get expanded to open or closed indices (default: open)</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Return settings in flat format (default: false)</summary>
		public bool? FlatSettings
		{
			get => Q<bool? >("flat_settings");
			set => Q("flat_settings", value);
		}

		///<summary>Ignore unavailable indexes (default: false)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Whether to return all default setting for each of the indices.</summary>
		public bool? IncludeDefaults
		{
			get => Q<bool? >("include_defaults");
			set => Q("include_defaults", value);
		}

		///<summary>Whether to add the type name to the response (default: false)</summary>
		///<remarks>Deprecated as of OpenSearch 2.0</remarks>
		public bool? IncludeTypeName
		{
			get => Q<bool? >("include_type_name");
			set => Q("include_type_name", value);
		}

		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public bool? Local
		{
			get => Q<bool? >("local");
			set => Q("local", value);
		}

		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetAliasRequest : IRequest<GetAliasRequestParameters>
	{
		[IgnoreDataMember]
		Names Name
		{
			get;
		}

		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for GetAlias <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
	public partial class GetAliasRequest : PlainRequestBase<GetAliasRequestParameters>, IGetAliasRequest
	{
		protected IGetAliasRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesGetAlias;
		///<summary>/_alias</summary>
		public GetAliasRequest(): base()
		{
		}

		///<summary>/_alias/{name}</summary>
		///<param name = "name">Optional, accepts null</param>
		public GetAliasRequest(Names name): base(r => r.Optional("name", name))
		{
		}

		///<summary>/{index}/_alias/{name}</summary>
		///<param name = "index">Optional, accepts null</param>
		///<param name = "name">Optional, accepts null</param>
		public GetAliasRequest(Indices index, Names name): base(r => r.Optional("index", index).Optional("name", name))
		{
		}

		///<summary>/{index}/_alias</summary>
		///<param name = "index">Optional, accepts null</param>
		public GetAliasRequest(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Names IGetAliasRequest.Name => Self.RouteValues.Get<Names>("name");
		[IgnoreDataMember]
		Indices IGetAliasRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public bool? Local
		{
			get => Q<bool? >("local");
			set => Q("local", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetFieldMappingRequest : IRequest<GetFieldMappingRequestParameters>
	{
		[IgnoreDataMember]
		Fields Fields
		{
			get;
		}

		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for GetFieldMapping <para>https://opensearch.org/docs/latest/opensearch/rest-api/update-mapping/</para></summary>
	public partial class GetFieldMappingRequest : PlainRequestBase<GetFieldMappingRequestParameters>, IGetFieldMappingRequest
	{
		protected IGetFieldMappingRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesGetFieldMapping;
		///<summary>/_mapping/field/{fields}</summary>
		///<param name = "fields">this parameter is required</param>
		public GetFieldMappingRequest(Fields fields): base(r => r.Required("fields", fields))
		{
		}

		///<summary>/{index}/_mapping/field/{fields}</summary>
		///<param name = "index">Optional, accepts null</param>
		///<param name = "fields">this parameter is required</param>
		public GetFieldMappingRequest(Indices index, Fields fields): base(r => r.Optional("index", index).Required("fields", fields))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected GetFieldMappingRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Fields IGetFieldMappingRequest.Fields => Self.RouteValues.Get<Fields>("fields");
		[IgnoreDataMember]
		Indices IGetFieldMappingRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Whether the default mapping values should be returned as well</summary>
		public bool? IncludeDefaults
		{
			get => Q<bool? >("include_defaults");
			set => Q("include_defaults", value);
		}

		///<summary>Whether a type should be returned in the body of the mappings.</summary>
		///<remarks>Deprecated as of OpenSearch 2.0</remarks>
		public bool? IncludeTypeName
		{
			get => Q<bool? >("include_type_name");
			set => Q("include_type_name", value);
		}

		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public bool? Local
		{
			get => Q<bool? >("local");
			set => Q("local", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetMappingRequest : IRequest<GetMappingRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for GetMapping <para>https://opensearch.org/docs/latest/opensearch/rest-api/update-mapping/</para></summary>
	public partial class GetMappingRequest : PlainRequestBase<GetMappingRequestParameters>, IGetMappingRequest
	{
		protected IGetMappingRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesGetMapping;
		///<summary>/_mapping</summary>
		public GetMappingRequest(): base()
		{
		}

		///<summary>/{index}/_mapping</summary>
		///<param name = "index">Optional, accepts null</param>
		public GetMappingRequest(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IGetMappingRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Whether to add the type name to the response (default: false)</summary>
		///<remarks>Deprecated as of OpenSearch 2.0</remarks>
		public bool? IncludeTypeName
		{
			get => Q<bool? >("include_type_name");
			set => Q("include_type_name", value);
		}

		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetIndexSettingsRequest : IRequest<GetIndexSettingsRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}

		[IgnoreDataMember]
		Names Name
		{
			get;
		}
	}

	///<summary>Request for GetSettings <para></para></summary>
	public partial class GetIndexSettingsRequest : PlainRequestBase<GetIndexSettingsRequestParameters>, IGetIndexSettingsRequest
	{
		protected IGetIndexSettingsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesGetSettings;
		///<summary>/_settings</summary>
		public GetIndexSettingsRequest(): base()
		{
		}

		///<summary>/{index}/_settings</summary>
		///<param name = "index">Optional, accepts null</param>
		public GetIndexSettingsRequest(Indices index): base(r => r.Optional("index", index))
		{
		}

		///<summary>/{index}/_settings/{name}</summary>
		///<param name = "index">Optional, accepts null</param>
		///<param name = "name">Optional, accepts null</param>
		public GetIndexSettingsRequest(Indices index, Names name): base(r => r.Optional("index", index).Optional("name", name))
		{
		}

		///<summary>/_settings/{name}</summary>
		///<param name = "name">Optional, accepts null</param>
		public GetIndexSettingsRequest(Names name): base(r => r.Optional("name", name))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IGetIndexSettingsRequest.Index => Self.RouteValues.Get<Indices>("index");
		[IgnoreDataMember]
		Names IGetIndexSettingsRequest.Name => Self.RouteValues.Get<Names>("name");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Return settings in flat format (default: false)</summary>
		public bool? FlatSettings
		{
			get => Q<bool? >("flat_settings");
			set => Q("flat_settings", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Whether to return all default setting for each of the indices.</summary>
		public bool? IncludeDefaults
		{
			get => Q<bool? >("include_defaults");
			set => Q("include_defaults", value);
		}

		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public bool? Local
		{
			get => Q<bool? >("local");
			set => Q("local", value);
		}

		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetIndexTemplateRequest : IRequest<GetIndexTemplateRequestParameters>
	{
		[IgnoreDataMember]
		Names Name
		{
			get;
		}
	}

	///<summary>Request for GetTemplate <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
	public partial class GetIndexTemplateRequest : PlainRequestBase<GetIndexTemplateRequestParameters>, IGetIndexTemplateRequest
	{
		protected IGetIndexTemplateRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesGetTemplate;
		///<summary>/_template</summary>
		public GetIndexTemplateRequest(): base()
		{
		}

		///<summary>/_template/{name}</summary>
		///<param name = "name">Optional, accepts null</param>
		public GetIndexTemplateRequest(Names name): base(r => r.Optional("name", name))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Names IGetIndexTemplateRequest.Name => Self.RouteValues.Get<Names>("name");
		// Request parameters
		///<summary>Return settings in flat format (default: false)</summary>
		public bool? FlatSettings
		{
			get => Q<bool? >("flat_settings");
			set => Q("flat_settings", value);
		}

		///<summary>Whether a type should be returned in the body of the mappings.</summary>
		///<remarks>Deprecated as of OpenSearch 2.0</remarks>
		public bool? IncludeTypeName
		{
			get => Q<bool? >("include_type_name");
			set => Q("include_type_name", value);
		}

		///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
		public bool? Local
		{
			get => Q<bool? >("local");
			set => Q("local", value);
		}

		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IOpenIndexRequest : IRequest<OpenIndexRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for Open <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/close-index/</para></summary>
	public partial class OpenIndexRequest : PlainRequestBase<OpenIndexRequestParameters>, IOpenIndexRequest
	{
		protected IOpenIndexRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesOpen;
		///<summary>/{index}/_open</summary>
		///<param name = "index">this parameter is required</param>
		public OpenIndexRequest(Indices index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected OpenIndexRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IOpenIndexRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Sets the number of active shards to wait for before the operation returns.</summary>
		public string WaitForActiveShards
		{
			get => Q<string>("wait_for_active_shards");
			set => Q("wait_for_active_shards", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IPutAliasRequest : IRequest<PutAliasRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}

		[IgnoreDataMember]
		Name Name
		{
			get;
		}
	}

	///<summary>Request for PutAlias <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
	public partial class PutAliasRequest : PlainRequestBase<PutAliasRequestParameters>, IPutAliasRequest
	{
		protected IPutAliasRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesPutAlias;
		///<summary>/{index}/_alias/{name}</summary>
		///<param name = "index">this parameter is required</param>
		///<param name = "name">this parameter is required</param>
		public PutAliasRequest(Indices index, Name name): base(r => r.Required("index", index).Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutAliasRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IPutAliasRequest.Index => Self.RouteValues.Get<Indices>("index");
		[IgnoreDataMember]
		Name IPutAliasRequest.Name => Self.RouteValues.Get<Name>("name");
		// Request parameters
		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit timestamp for the document</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IPutMappingRequest : IRequest<PutMappingRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	public partial interface IPutMappingRequest<TDocument> : IPutMappingRequest
	{
	}

	///<summary>Request for PutMapping <para>https://opensearch.org/docs/latest/opensearch/rest-api/update-mapping/</para></summary>
	public partial class PutMappingRequest : PlainRequestBase<PutMappingRequestParameters>, IPutMappingRequest
	{
		protected IPutMappingRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesPutMapping;
		///<summary>/{index}/_mapping</summary>
		///<param name = "index">this parameter is required</param>
		public PutMappingRequest(Indices index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutMappingRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IPutMappingRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Whether a type should be expected in the body of the mappings.</summary>
		///<remarks>Deprecated as of OpenSearch 2.0</remarks>
		public bool? IncludeTypeName
		{
			get => Q<bool? >("include_type_name");
			set => Q("include_type_name", value);
		}

		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}

		///<summary>When true, applies mappings only to the write index of an alias</summary>
		public bool? WriteIndexOnly
		{
			get => Q<bool? >("write_index_only");
			set => Q("write_index_only", value);
		}
	}

	public partial class PutMappingRequest<TDocument> : PutMappingRequest, IPutMappingRequest<TDocument>
	{
		protected IPutMappingRequest<TDocument> TypedSelf => this;
		///<summary>/{index}/_mapping</summary>
		///<param name = "index">this parameter is required</param>
		public PutMappingRequest(Indices index): base(index)
		{
		}

		///<summary>/{index}/_mapping</summary>
		public PutMappingRequest(): base(typeof(TDocument))
		{
		}
	}

	[InterfaceDataContract]
	public partial interface IUpdateIndexSettingsRequest : IRequest<UpdateIndexSettingsRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for UpdateSettings <para></para></summary>
	public partial class UpdateIndexSettingsRequest : PlainRequestBase<UpdateIndexSettingsRequestParameters>, IUpdateIndexSettingsRequest
	{
		protected IUpdateIndexSettingsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesUpdateSettings;
		///<summary>/_settings</summary>
		public UpdateIndexSettingsRequest(): base()
		{
		}

		///<summary>/{index}/_settings</summary>
		///<param name = "index">Optional, accepts null</param>
		public UpdateIndexSettingsRequest(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IUpdateIndexSettingsRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Return settings in flat format (default: false)</summary>
		public bool? FlatSettings
		{
			get => Q<bool? >("flat_settings");
			set => Q("flat_settings", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Whether to update existing settings. If set to `true` existing settings on an index remain unchanged, the default is `false`</summary>
		public bool? PreserveExisting
		{
			get => Q<bool? >("preserve_existing");
			set => Q("preserve_existing", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IPutIndexTemplateRequest : IRequest<PutIndexTemplateRequestParameters>
	{
		[IgnoreDataMember]
		Name Name
		{
			get;
		}
	}

	///<summary>Request for PutTemplate <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
	public partial class PutIndexTemplateRequest : PlainRequestBase<PutIndexTemplateRequestParameters>, IPutIndexTemplateRequest
	{
		protected IPutIndexTemplateRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesPutTemplate;
		///<summary>/_template/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public PutIndexTemplateRequest(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutIndexTemplateRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IPutIndexTemplateRequest.Name => Self.RouteValues.Get<Name>("name");
		// Request parameters
		///<summary>Whether the index template should only be added if new or can also replace an existing one</summary>
		public bool? Create
		{
			get => Q<bool? >("create");
			set => Q("create", value);
		}

		///<summary>Whether a type should be returned in the body of the mappings.</summary>
		///<remarks>Deprecated as of OpenSearch 2.0</remarks>
		public bool? IncludeTypeName
		{
			get => Q<bool? >("include_type_name");
			set => Q("include_type_name", value);
		}

		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IRefreshRequest : IRequest<RefreshRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for Refresh <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</para></summary>
	public partial class RefreshRequest : PlainRequestBase<RefreshRequestParameters>, IRefreshRequest
	{
		protected IRefreshRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesRefresh;
		///<summary>/_refresh</summary>
		public RefreshRequest(): base()
		{
		}

		///<summary>/{index}/_refresh</summary>
		///<param name = "index">Optional, accepts null</param>
		public RefreshRequest(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IRefreshRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IResolveIndexRequest : IRequest<ResolveIndexRequestParameters>
	{
		[IgnoreDataMember]
		Names Name
		{
			get;
		}
	}

	///<summary>Request for Resolve <para></para></summary>
	///<remarks>Note: Experimental within the OpenSearch server, this functionality is experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features.</remarks>
	public partial class ResolveIndexRequest : PlainRequestBase<ResolveIndexRequestParameters>, IResolveIndexRequest
	{
		protected IResolveIndexRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesResolve;
		///<summary>/_resolve/index/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public ResolveIndexRequest(Names name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ResolveIndexRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Names IResolveIndexRequest.Name => Self.RouteValues.Get<Names>("name");
		// Request parameters
		///<summary>Whether wildcard expressions should get expanded to open or closed indices (default: open)</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IRolloverIndexRequest : IRequest<RolloverIndexRequestParameters>
	{
		[IgnoreDataMember]
		Name Alias
		{
			get;
		}

		[IgnoreDataMember]
		IndexName NewIndex
		{
			get;
		}
	}

	///<summary>Request for Rollover <para>https://opensearch.org/docs/latest/opensearch/data-streams/#step-5-rollover-a-data-stream</para></summary>
	public partial class RolloverIndexRequest : PlainRequestBase<RolloverIndexRequestParameters>, IRolloverIndexRequest
	{
		protected IRolloverIndexRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesRollover;
		///<summary>/{alias}/_rollover</summary>
		///<param name = "alias">this parameter is required</param>
		public RolloverIndexRequest(Name alias): base(r => r.Required("alias", alias))
		{
		}

		///<summary>/{alias}/_rollover/{new_index}</summary>
		///<param name = "alias">this parameter is required</param>
		///<param name = "newIndex">Optional, accepts null</param>
		public RolloverIndexRequest(Name alias, IndexName newIndex): base(r => r.Required("alias", alias).Optional("new_index", newIndex))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected RolloverIndexRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IRolloverIndexRequest.Alias => Self.RouteValues.Get<Name>("alias");
		[IgnoreDataMember]
		IndexName IRolloverIndexRequest.NewIndex => Self.RouteValues.Get<IndexName>("new_index");
		// Request parameters
		///<summary>If set to true the rollover action will only be validated but not actually performed even if a condition matches. The default is false</summary>
		public bool? DryRun
		{
			get => Q<bool? >("dry_run");
			set => Q("dry_run", value);
		}

		///<summary>Whether a type should be included in the body of the mappings.</summary>
		///<remarks>Deprecated as of OpenSearch 2.0</remarks>
		public bool? IncludeTypeName
		{
			get => Q<bool? >("include_type_name");
			set => Q("include_type_name", value);
		}

		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Set the number of active shards to wait for on the newly created rollover index before the operation returns.</summary>
		public string WaitForActiveShards
		{
			get => Q<string>("wait_for_active_shards");
			set => Q("wait_for_active_shards", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IIndicesShardStoresRequest : IRequest<IndicesShardStoresRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	///<summary>Request for ShardStores <para></para></summary>
	public partial class IndicesShardStoresRequest : PlainRequestBase<IndicesShardStoresRequestParameters>, IIndicesShardStoresRequest
	{
		protected IIndicesShardStoresRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesShardStores;
		///<summary>/_shard_stores</summary>
		public IndicesShardStoresRequest(): base()
		{
		}

		///<summary>/{index}/_shard_stores</summary>
		///<param name = "index">Optional, accepts null</param>
		public IndicesShardStoresRequest(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IIndicesShardStoresRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>A comma-separated list of statuses used to filter on shards to get store information for</summary>
		public string[] Status
		{
			get => Q<string[]>("status");
			set => Q("status", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IShrinkIndexRequest : IRequest<ShrinkIndexRequestParameters>
	{
		[IgnoreDataMember]
		IndexName Index
		{
			get;
		}

		[IgnoreDataMember]
		IndexName Target
		{
			get;
		}
	}

	///<summary>Request for Shrink <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/shrink-index/</para></summary>
	public partial class ShrinkIndexRequest : PlainRequestBase<ShrinkIndexRequestParameters>, IShrinkIndexRequest
	{
		protected IShrinkIndexRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesShrink;
		///<summary>/{index}/_shrink/{target}</summary>
		///<param name = "index">this parameter is required</param>
		///<param name = "target">this parameter is required</param>
		public ShrinkIndexRequest(IndexName index, IndexName target): base(r => r.Required("index", index).Required("target", target))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ShrinkIndexRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		IndexName IShrinkIndexRequest.Index => Self.RouteValues.Get<IndexName>("index");
		[IgnoreDataMember]
		IndexName IShrinkIndexRequest.Target => Self.RouteValues.Get<IndexName>("target");
		// Request parameters
		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Set the number of active shards to wait for on the shrunken index before the operation returns.</summary>
		public string WaitForActiveShards
		{
			get => Q<string>("wait_for_active_shards");
			set => Q("wait_for_active_shards", value);
		}
	}

	[InterfaceDataContract]
	public partial interface ISplitIndexRequest : IRequest<SplitIndexRequestParameters>
	{
		[IgnoreDataMember]
		IndexName Index
		{
			get;
		}

		[IgnoreDataMember]
		IndexName Target
		{
			get;
		}
	}

	///<summary>Request for Split <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/split/</para></summary>
	public partial class SplitIndexRequest : PlainRequestBase<SplitIndexRequestParameters>, ISplitIndexRequest
	{
		protected ISplitIndexRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesSplit;
		///<summary>/{index}/_split/{target}</summary>
		///<param name = "index">this parameter is required</param>
		///<param name = "target">this parameter is required</param>
		public SplitIndexRequest(IndexName index, IndexName target): base(r => r.Required("index", index).Required("target", target))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected SplitIndexRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		IndexName ISplitIndexRequest.Index => Self.RouteValues.Get<IndexName>("index");
		[IgnoreDataMember]
		IndexName ISplitIndexRequest.Target => Self.RouteValues.Get<IndexName>("target");
		// Request parameters
		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Set the number of active shards to wait for on the shrunken index before the operation returns.</summary>
		public string WaitForActiveShards
		{
			get => Q<string>("wait_for_active_shards");
			set => Q("wait_for_active_shards", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IBulkAliasRequest : IRequest<BulkAliasRequestParameters>
	{
	}

	///<summary>Request for BulkAlias <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
	public partial class BulkAliasRequest : PlainRequestBase<BulkAliasRequestParameters>, IBulkAliasRequest
	{
		protected IBulkAliasRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesBulkAlias;
		// values part of the url path
		// Request parameters
		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public Time ClusterManagerTimeout
		{
			get => Q<Time>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Request timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IValidateQueryRequest : IRequest<ValidateQueryRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}
	}

	public partial interface IValidateQueryRequest<TDocument> : IValidateQueryRequest
	{
	}

	///<summary>Request for ValidateQuery <para></para></summary>
	public partial class ValidateQueryRequest : PlainRequestBase<ValidateQueryRequestParameters>, IValidateQueryRequest
	{
		protected IValidateQueryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesValidateQuery;
		///<summary>/_validate/query</summary>
		public ValidateQueryRequest(): base()
		{
		}

		///<summary>/{index}/_validate/query</summary>
		///<param name = "index">Optional, accepts null</param>
		public ValidateQueryRequest(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IValidateQueryRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>Execute validation on all shards instead of one random shard per index</summary>
		public bool? AllShards
		{
			get => Q<bool? >("all_shards");
			set => Q("all_shards", value);
		}

		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Specify whether wildcard and prefix queries should be analyzed (default: false)</summary>
		public bool? AnalyzeWildcard
		{
			get => Q<bool? >("analyze_wildcard");
			set => Q("analyze_wildcard", value);
		}

		///<summary>The analyzer to use for the query string</summary>
		public string Analyzer
		{
			get => Q<string>("analyzer");
			set => Q("analyzer", value);
		}

		///<summary>The default operator for query string query (AND or OR)</summary>
		public DefaultOperator? DefaultOperator
		{
			get => Q<DefaultOperator? >("default_operator");
			set => Q("default_operator", value);
		}

		///<summary>The field to use as default where no field prefix is given in the query string</summary>
		public string Df
		{
			get => Q<string>("df");
			set => Q("df", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Return detailed information about the error</summary>
		public bool? Explain
		{
			get => Q<bool? >("explain");
			set => Q("explain", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Specify whether format-based query failures (such as providing text to a numeric field) should be ignored</summary>
		public bool? Lenient
		{
			get => Q<bool? >("lenient");
			set => Q("lenient", value);
		}

		///<summary>Query in the Lucene query string syntax</summary>
		public string QueryOnQueryString
		{
			get => Q<string>("q");
			set => Q("q", value);
		}

		///<summary>Provide a more detailed explanation showing the actual Lucene query that will be executed.</summary>
		public bool? Rewrite
		{
			get => Q<bool? >("rewrite");
			set => Q("rewrite", value);
		}
	}

	public partial class ValidateQueryRequest<TDocument> : ValidateQueryRequest, IValidateQueryRequest<TDocument>
	{
		protected IValidateQueryRequest<TDocument> TypedSelf => this;
		///<summary>/{index}/_validate/query</summary>
		public ValidateQueryRequest(): base(typeof(TDocument))
		{
		}

		///<summary>/{index}/_validate/query</summary>
		///<param name = "index">Optional, accepts null</param>
		public ValidateQueryRequest(Indices index): base(index)
		{
		}
	}
}
