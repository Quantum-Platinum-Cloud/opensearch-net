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
using System.Threading;
using System.Threading.Tasks;
using OpenSearch.Client.Specification.CatApi;
using OpenSearch.Client.Specification.ClusterApi;
using OpenSearch.Client.Specification.DanglingIndicesApi;
using OpenSearch.Client.Specification.IndicesApi;
using OpenSearch.Client.Specification.IngestApi;
using OpenSearch.Client.Specification.NodesApi;
using OpenSearch.Client.Specification.SnapshotApi;
using OpenSearch.Client.Specification.TasksApi;
using OpenSearch.Client;

// ReSharper disable RedundantTypeArgumentsOfMethod
namespace OpenSearch.Client
{
	///<summary>
	///OpenSearch high level client
	///</summary>
	public partial class OpenSearchClient : IOpenSearchClient
	{
		///<summary>Cat APIs</summary>
		public CatNamespace Cat
		{
			get;
			private set;
		}

		///<summary>Cluster APIs</summary>
		public ClusterNamespace Cluster
		{
			get;
			private set;
		}

		///<summary>Dangling Indices APIs</summary>
		public DanglingIndicesNamespace DanglingIndices
		{
			get;
			private set;
		}

		///<summary>Indices APIs</summary>
		public IndicesNamespace Indices
		{
			get;
			private set;
		}

		///<summary>Ingest APIs</summary>
		public IngestNamespace Ingest
		{
			get;
			private set;
		}

		///<summary>Nodes APIs</summary>
		public NodesNamespace Nodes
		{
			get;
			private set;
		}

		///<summary>Snapshot APIs</summary>
		public SnapshotNamespace Snapshot
		{
			get;
			private set;
		}

		///<summary>Tasks APIs</summary>
		public TasksNamespace Tasks
		{
			get;
			private set;
		}

		partial void SetupNamespaces()
		{
			Cat = new CatNamespace(this);
			Cluster = new ClusterNamespace(this);
			DanglingIndices = new DanglingIndicesNamespace(this);
			Indices = new IndicesNamespace(this);
			Ingest = new IngestNamespace(this);
			Nodes = new NodesNamespace(this);
			Snapshot = new SnapshotNamespace(this);
			Tasks = new TasksNamespace(this);
		}

		/// <summary>
		/// <c>POST</c> request to the <c>bulk</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/bulk/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/bulk/</a>
		/// </summary>
		public BulkResponse Bulk(Func<BulkDescriptor, IBulkRequest> selector) => Bulk(selector.InvokeOrDefault(new BulkDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>bulk</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/bulk/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/bulk/</a>
		/// </summary>
		public Task<BulkResponse> BulkAsync(Func<BulkDescriptor, IBulkRequest> selector, CancellationToken ct = default) => BulkAsync(selector.InvokeOrDefault(new BulkDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>bulk</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/bulk/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/bulk/</a>
		/// </summary>
		public BulkResponse Bulk(IBulkRequest request) => DoRequest<IBulkRequest, BulkResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>bulk</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/bulk/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/bulk/</a>
		/// </summary>
		public Task<BulkResponse> BulkAsync(IBulkRequest request, CancellationToken ct = default) => DoRequestAsync<IBulkRequest, BulkResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>clear_scroll</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/scroll/">https://opensearch.org/docs/latest/opensearch/rest-api/scroll/</a>
		/// </summary>
		public ClearScrollResponse ClearScroll(Func<ClearScrollDescriptor, IClearScrollRequest> selector = null) => ClearScroll(selector.InvokeOrDefault(new ClearScrollDescriptor()));
		/// <summary>
		/// <c>DELETE</c> request to the <c>clear_scroll</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/scroll/">https://opensearch.org/docs/latest/opensearch/rest-api/scroll/</a>
		/// </summary>
		public Task<ClearScrollResponse> ClearScrollAsync(Func<ClearScrollDescriptor, IClearScrollRequest> selector = null, CancellationToken ct = default) => ClearScrollAsync(selector.InvokeOrDefault(new ClearScrollDescriptor()), ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>clear_scroll</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/scroll/">https://opensearch.org/docs/latest/opensearch/rest-api/scroll/</a>
		/// </summary>
		public ClearScrollResponse ClearScroll(IClearScrollRequest request) => DoRequest<IClearScrollRequest, ClearScrollResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>DELETE</c> request to the <c>clear_scroll</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/scroll/">https://opensearch.org/docs/latest/opensearch/rest-api/scroll/</a>
		/// </summary>
		public Task<ClearScrollResponse> ClearScrollAsync(IClearScrollRequest request, CancellationToken ct = default) => DoRequestAsync<IClearScrollRequest, ClearScrollResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>count</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/count/">https://opensearch.org/docs/latest/opensearch/rest-api/count/</a>
		/// </summary>
		public CountResponse Count<TDocument>(Func<CountDescriptor<TDocument>, ICountRequest> selector = null)
			where TDocument : class => Count(selector.InvokeOrDefault(new CountDescriptor<TDocument>()));
		/// <summary>
		/// <c>POST</c> request to the <c>count</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/count/">https://opensearch.org/docs/latest/opensearch/rest-api/count/</a>
		/// </summary>
		public Task<CountResponse> CountAsync<TDocument>(Func<CountDescriptor<TDocument>, ICountRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => CountAsync(selector.InvokeOrDefault(new CountDescriptor<TDocument>()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>count</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/count/">https://opensearch.org/docs/latest/opensearch/rest-api/count/</a>
		/// </summary>
		public CountResponse Count(ICountRequest request) => DoRequest<ICountRequest, CountResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>count</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/count/">https://opensearch.org/docs/latest/opensearch/rest-api/count/</a>
		/// </summary>
		public Task<CountResponse> CountAsync(ICountRequest request, CancellationToken ct = default) => DoRequestAsync<ICountRequest, CountResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>create</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/</a>
		/// </summary>
		public CreateResponse Create<TDocument>(TDocument document, Func<CreateDescriptor<TDocument>, ICreateRequest<TDocument>> selector)
			where TDocument : class => Create<TDocument>(selector.InvokeOrDefault(new CreateDescriptor<TDocument>(documentWithId: document)));
		/// <summary>
		/// <c>PUT</c> request to the <c>create</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/</a>
		/// </summary>
		public Task<CreateResponse> CreateAsync<TDocument>(TDocument document, Func<CreateDescriptor<TDocument>, ICreateRequest<TDocument>> selector, CancellationToken ct = default)
			where TDocument : class => CreateAsync<TDocument>(selector.InvokeOrDefault(new CreateDescriptor<TDocument>(documentWithId: document)), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>create</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/</a>
		/// </summary>
		public CreateResponse Create<TDocument>(ICreateRequest<TDocument> request)
			where TDocument : class => DoRequest<ICreateRequest<TDocument>, CreateResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>create</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/</a>
		/// </summary>
		public Task<CreateResponse> CreateAsync<TDocument>(ICreateRequest<TDocument> request, CancellationToken ct = default)
			where TDocument : class => DoRequestAsync<ICreateRequest<TDocument>, CreateResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>delete</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-document/</a>
		/// </summary>
		public DeleteResponse Delete<TDocument>(DocumentPath<TDocument> id, Func<DeleteDescriptor<TDocument>, IDeleteRequest> selector = null)
			where TDocument : class => Delete(selector.InvokeOrDefault(new DeleteDescriptor<TDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)));
		/// <summary>
		/// <c>DELETE</c> request to the <c>delete</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-document/</a>
		/// </summary>
		public Task<DeleteResponse> DeleteAsync<TDocument>(DocumentPath<TDocument> id, Func<DeleteDescriptor<TDocument>, IDeleteRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => DeleteAsync(selector.InvokeOrDefault(new DeleteDescriptor<TDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)), ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>delete</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-document/</a>
		/// </summary>
		public DeleteResponse Delete(IDeleteRequest request) => DoRequest<IDeleteRequest, DeleteResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>DELETE</c> request to the <c>delete</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-document/</a>
		/// </summary>
		public Task<DeleteResponse> DeleteAsync(IDeleteRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteRequest, DeleteResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>delete_by_query</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/</a>
		/// </summary>
		public DeleteByQueryResponse DeleteByQuery<TDocument>(Func<DeleteByQueryDescriptor<TDocument>, IDeleteByQueryRequest> selector)
			where TDocument : class => DeleteByQuery(selector.InvokeOrDefault(new DeleteByQueryDescriptor<TDocument>()));
		/// <summary>
		/// <c>POST</c> request to the <c>delete_by_query</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/</a>
		/// </summary>
		public Task<DeleteByQueryResponse> DeleteByQueryAsync<TDocument>(Func<DeleteByQueryDescriptor<TDocument>, IDeleteByQueryRequest> selector, CancellationToken ct = default)
			where TDocument : class => DeleteByQueryAsync(selector.InvokeOrDefault(new DeleteByQueryDescriptor<TDocument>()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>delete_by_query</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/</a>
		/// </summary>
		public DeleteByQueryResponse DeleteByQuery(IDeleteByQueryRequest request) => DoRequest<IDeleteByQueryRequest, DeleteByQueryResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>delete_by_query</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/</a>
		/// </summary>
		public Task<DeleteByQueryResponse> DeleteByQueryAsync(IDeleteByQueryRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteByQueryRequest, DeleteByQueryResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>delete_by_query_rethrottle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/</a>
		/// </summary>
		public ListTasksResponse DeleteByQueryRethrottle(TaskId taskId, Func<DeleteByQueryRethrottleDescriptor, IDeleteByQueryRethrottleRequest> selector = null) => DeleteByQueryRethrottle(selector.InvokeOrDefault(new DeleteByQueryRethrottleDescriptor(taskId: taskId)));
		/// <summary>
		/// <c>POST</c> request to the <c>delete_by_query_rethrottle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/</a>
		/// </summary>
		public Task<ListTasksResponse> DeleteByQueryRethrottleAsync(TaskId taskId, Func<DeleteByQueryRethrottleDescriptor, IDeleteByQueryRethrottleRequest> selector = null, CancellationToken ct = default) => DeleteByQueryRethrottleAsync(selector.InvokeOrDefault(new DeleteByQueryRethrottleDescriptor(taskId: taskId)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>delete_by_query_rethrottle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/</a>
		/// </summary>
		public ListTasksResponse DeleteByQueryRethrottle(IDeleteByQueryRethrottleRequest request) => DoRequest<IDeleteByQueryRethrottleRequest, ListTasksResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>delete_by_query_rethrottle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/</a>
		/// </summary>
		public Task<ListTasksResponse> DeleteByQueryRethrottleAsync(IDeleteByQueryRethrottleRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteByQueryRethrottleRequest, ListTasksResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>delete_script</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public DeleteScriptResponse DeleteScript(Id id, Func<DeleteScriptDescriptor, IDeleteScriptRequest> selector = null) => DeleteScript(selector.InvokeOrDefault(new DeleteScriptDescriptor(id: id)));
		/// <summary>
		/// <c>DELETE</c> request to the <c>delete_script</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<DeleteScriptResponse> DeleteScriptAsync(Id id, Func<DeleteScriptDescriptor, IDeleteScriptRequest> selector = null, CancellationToken ct = default) => DeleteScriptAsync(selector.InvokeOrDefault(new DeleteScriptDescriptor(id: id)), ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>delete_script</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public DeleteScriptResponse DeleteScript(IDeleteScriptRequest request) => DoRequest<IDeleteScriptRequest, DeleteScriptResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>DELETE</c> request to the <c>delete_script</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<DeleteScriptResponse> DeleteScriptAsync(IDeleteScriptRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteScriptRequest, DeleteScriptResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>HEAD</c> request to the <c>exists</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public ExistsResponse DocumentExists<TDocument>(DocumentPath<TDocument> id, Func<DocumentExistsDescriptor<TDocument>, IDocumentExistsRequest> selector = null)
			where TDocument : class => DocumentExists(selector.InvokeOrDefault(new DocumentExistsDescriptor<TDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)));
		/// <summary>
		/// <c>HEAD</c> request to the <c>exists</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public Task<ExistsResponse> DocumentExistsAsync<TDocument>(DocumentPath<TDocument> id, Func<DocumentExistsDescriptor<TDocument>, IDocumentExistsRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => DocumentExistsAsync(selector.InvokeOrDefault(new DocumentExistsDescriptor<TDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)), ct);
		/// <summary>
		/// <c>HEAD</c> request to the <c>exists</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public ExistsResponse DocumentExists(IDocumentExistsRequest request) => DoRequest<IDocumentExistsRequest, ExistsResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>HEAD</c> request to the <c>exists</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public Task<ExistsResponse> DocumentExistsAsync(IDocumentExistsRequest request, CancellationToken ct = default) => DoRequestAsync<IDocumentExistsRequest, ExistsResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>HEAD</c> request to the <c>exists_source</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public ExistsResponse SourceExists<TDocument>(DocumentPath<TDocument> id, Func<SourceExistsDescriptor<TDocument>, ISourceExistsRequest> selector = null)
			where TDocument : class => SourceExists(selector.InvokeOrDefault(new SourceExistsDescriptor<TDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)));
		/// <summary>
		/// <c>HEAD</c> request to the <c>exists_source</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public Task<ExistsResponse> SourceExistsAsync<TDocument>(DocumentPath<TDocument> id, Func<SourceExistsDescriptor<TDocument>, ISourceExistsRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => SourceExistsAsync(selector.InvokeOrDefault(new SourceExistsDescriptor<TDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)), ct);
		/// <summary>
		/// <c>HEAD</c> request to the <c>exists_source</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public ExistsResponse SourceExists(ISourceExistsRequest request) => DoRequest<ISourceExistsRequest, ExistsResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>HEAD</c> request to the <c>exists_source</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public Task<ExistsResponse> SourceExistsAsync(ISourceExistsRequest request, CancellationToken ct = default) => DoRequestAsync<ISourceExistsRequest, ExistsResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>explain</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/explain/">https://opensearch.org/docs/latest/opensearch/rest-api/explain/</a>
		/// </summary>
		public ExplainResponse<TDocument> Explain<TDocument>(DocumentPath<TDocument> id, Func<ExplainDescriptor<TDocument>, IExplainRequest> selector = null)
			where TDocument : class => Explain<TDocument>(selector.InvokeOrDefault(new ExplainDescriptor<TDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)));
		/// <summary>
		/// <c>POST</c> request to the <c>explain</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/explain/">https://opensearch.org/docs/latest/opensearch/rest-api/explain/</a>
		/// </summary>
		public Task<ExplainResponse<TDocument>> ExplainAsync<TDocument>(DocumentPath<TDocument> id, Func<ExplainDescriptor<TDocument>, IExplainRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => ExplainAsync<TDocument>(selector.InvokeOrDefault(new ExplainDescriptor<TDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>explain</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/explain/">https://opensearch.org/docs/latest/opensearch/rest-api/explain/</a>
		/// </summary>
		public ExplainResponse<TDocument> Explain<TDocument>(IExplainRequest request)
			where TDocument : class => DoRequest<IExplainRequest, ExplainResponse<TDocument>>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>explain</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/explain/">https://opensearch.org/docs/latest/opensearch/rest-api/explain/</a>
		/// </summary>
		public Task<ExplainResponse<TDocument>> ExplainAsync<TDocument>(IExplainRequest request, CancellationToken ct = default)
			where TDocument : class => DoRequestAsync<IExplainRequest, ExplainResponse<TDocument>>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>field_caps</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public FieldCapabilitiesResponse FieldCapabilities(Indices index = null, Func<FieldCapabilitiesDescriptor, IFieldCapabilitiesRequest> selector = null) => FieldCapabilities(selector.InvokeOrDefault(new FieldCapabilitiesDescriptor().Index(index: index)));
		/// <summary>
		/// <c>POST</c> request to the <c>field_caps</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<FieldCapabilitiesResponse> FieldCapabilitiesAsync(Indices index = null, Func<FieldCapabilitiesDescriptor, IFieldCapabilitiesRequest> selector = null, CancellationToken ct = default) => FieldCapabilitiesAsync(selector.InvokeOrDefault(new FieldCapabilitiesDescriptor().Index(index: index)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>field_caps</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public FieldCapabilitiesResponse FieldCapabilities(IFieldCapabilitiesRequest request) => DoRequest<IFieldCapabilitiesRequest, FieldCapabilitiesResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>field_caps</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<FieldCapabilitiesResponse> FieldCapabilitiesAsync(IFieldCapabilitiesRequest request, CancellationToken ct = default) => DoRequestAsync<IFieldCapabilitiesRequest, FieldCapabilitiesResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public GetResponse<TDocument> Get<TDocument>(DocumentPath<TDocument> id, Func<GetDescriptor<TDocument>, IGetRequest> selector = null)
			where TDocument : class => Get<TDocument>(selector.InvokeOrDefault(new GetDescriptor<TDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)));
		/// <summary>
		/// <c>GET</c> request to the <c>get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public Task<GetResponse<TDocument>> GetAsync<TDocument>(DocumentPath<TDocument> id, Func<GetDescriptor<TDocument>, IGetRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => GetAsync<TDocument>(selector.InvokeOrDefault(new GetDescriptor<TDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public GetResponse<TDocument> Get<TDocument>(IGetRequest request)
			where TDocument : class => DoRequest<IGetRequest, GetResponse<TDocument>>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public Task<GetResponse<TDocument>> GetAsync<TDocument>(IGetRequest request, CancellationToken ct = default)
			where TDocument : class => DoRequestAsync<IGetRequest, GetResponse<TDocument>>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>get_script</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public GetScriptResponse GetScript(Id id, Func<GetScriptDescriptor, IGetScriptRequest> selector = null) => GetScript(selector.InvokeOrDefault(new GetScriptDescriptor(id: id)));
		/// <summary>
		/// <c>GET</c> request to the <c>get_script</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<GetScriptResponse> GetScriptAsync(Id id, Func<GetScriptDescriptor, IGetScriptRequest> selector = null, CancellationToken ct = default) => GetScriptAsync(selector.InvokeOrDefault(new GetScriptDescriptor(id: id)), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>get_script</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public GetScriptResponse GetScript(IGetScriptRequest request) => DoRequest<IGetScriptRequest, GetScriptResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>get_script</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<GetScriptResponse> GetScriptAsync(IGetScriptRequest request, CancellationToken ct = default) => DoRequestAsync<IGetScriptRequest, GetScriptResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>get_source</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public SourceResponse<TDocument> Source<TDocument>(DocumentPath<TDocument> id, Func<SourceDescriptor<TDocument>, ISourceRequest> selector = null)
			where TDocument : class => Source<TDocument>(selector.InvokeOrDefault(new SourceDescriptor<TDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)));
		/// <summary>
		/// <c>GET</c> request to the <c>get_source</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public Task<SourceResponse<TDocument>> SourceAsync<TDocument>(DocumentPath<TDocument> id, Func<SourceDescriptor<TDocument>, ISourceRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => SourceAsync<TDocument>(selector.InvokeOrDefault(new SourceDescriptor<TDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>get_source</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public SourceResponse<TDocument> Source<TDocument>(ISourceRequest request)
			where TDocument : class => DoRequest<ISourceRequest, SourceResponse<TDocument>>(request, ResponseBuilder(request.RequestParameters, SourceRequestResponseBuilder<TDocument>.Instance));
		/// <summary>
		/// <c>GET</c> request to the <c>get_source</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</a>
		/// </summary>
		public Task<SourceResponse<TDocument>> SourceAsync<TDocument>(ISourceRequest request, CancellationToken ct = default)
			where TDocument : class => DoRequestAsync<ISourceRequest, SourceResponse<TDocument>>(request, ResponseBuilder(request.RequestParameters, SourceRequestResponseBuilder<TDocument>.Instance), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>index</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/</a>
		/// </summary>
		public IndexResponse Index<TDocument>(TDocument document, Func<IndexDescriptor<TDocument>, IIndexRequest<TDocument>> selector)
			where TDocument : class => Index<TDocument>(selector.InvokeOrDefault(new IndexDescriptor<TDocument>(documentWithId: document)));
		/// <summary>
		/// <c>PUT</c> request to the <c>index</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/</a>
		/// </summary>
		public Task<IndexResponse> IndexAsync<TDocument>(TDocument document, Func<IndexDescriptor<TDocument>, IIndexRequest<TDocument>> selector, CancellationToken ct = default)
			where TDocument : class => IndexAsync<TDocument>(selector.InvokeOrDefault(new IndexDescriptor<TDocument>(documentWithId: document)), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>index</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/</a>
		/// </summary>
		public IndexResponse Index<TDocument>(IIndexRequest<TDocument> request)
			where TDocument : class => DoRequest<IIndexRequest<TDocument>, IndexResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>index</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/</a>
		/// </summary>
		public Task<IndexResponse> IndexAsync<TDocument>(IIndexRequest<TDocument> request, CancellationToken ct = default)
			where TDocument : class => DoRequestAsync<IIndexRequest<TDocument>, IndexResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>info</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/index/">https://opensearch.org/docs/latest/opensearch/index/</a>
		/// </summary>
		public RootNodeInfoResponse RootNodeInfo(Func<RootNodeInfoDescriptor, IRootNodeInfoRequest> selector = null) => RootNodeInfo(selector.InvokeOrDefault(new RootNodeInfoDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>info</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/index/">https://opensearch.org/docs/latest/opensearch/index/</a>
		/// </summary>
		public Task<RootNodeInfoResponse> RootNodeInfoAsync(Func<RootNodeInfoDescriptor, IRootNodeInfoRequest> selector = null, CancellationToken ct = default) => RootNodeInfoAsync(selector.InvokeOrDefault(new RootNodeInfoDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>info</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/index/">https://opensearch.org/docs/latest/opensearch/index/</a>
		/// </summary>
		public RootNodeInfoResponse RootNodeInfo(IRootNodeInfoRequest request) => DoRequest<IRootNodeInfoRequest, RootNodeInfoResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>info</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/index/">https://opensearch.org/docs/latest/opensearch/index/</a>
		/// </summary>
		public Task<RootNodeInfoResponse> RootNodeInfoAsync(IRootNodeInfoRequest request, CancellationToken ct = default) => DoRequestAsync<IRootNodeInfoRequest, RootNodeInfoResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>mget</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/multi-get/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/multi-get/</a>
		/// </summary>
		public MultiGetResponse MultiGet(Func<MultiGetDescriptor, IMultiGetRequest> selector = null) => MultiGet(selector.InvokeOrDefault(new MultiGetDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>mget</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/multi-get/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/multi-get/</a>
		/// </summary>
		public Task<MultiGetResponse> MultiGetAsync(Func<MultiGetDescriptor, IMultiGetRequest> selector = null, CancellationToken ct = default) => MultiGetAsync(selector.InvokeOrDefault(new MultiGetDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>mget</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/multi-get/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/multi-get/</a>
		/// </summary>
		public MultiGetResponse MultiGet(IMultiGetRequest request) => DoRequest<IMultiGetRequest, MultiGetResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>mget</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/multi-get/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/multi-get/</a>
		/// </summary>
		public Task<MultiGetResponse> MultiGetAsync(IMultiGetRequest request, CancellationToken ct = default) => DoRequestAsync<IMultiGetRequest, MultiGetResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>msearch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/">https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</a>
		/// </summary>
		public MultiSearchResponse MultiSearch(Indices index = null, Func<MultiSearchDescriptor, IMultiSearchRequest> selector = null) => MultiSearch(selector.InvokeOrDefault(new MultiSearchDescriptor().Index(index: index)));
		/// <summary>
		/// <c>POST</c> request to the <c>msearch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/">https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</a>
		/// </summary>
		public Task<MultiSearchResponse> MultiSearchAsync(Indices index = null, Func<MultiSearchDescriptor, IMultiSearchRequest> selector = null, CancellationToken ct = default) => MultiSearchAsync(selector.InvokeOrDefault(new MultiSearchDescriptor().Index(index: index)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>msearch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/">https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</a>
		/// </summary>
		public MultiSearchResponse MultiSearch(IMultiSearchRequest request) => DoRequest<IMultiSearchRequest, MultiSearchResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>msearch</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/">https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</a>
		/// </summary>
		public Task<MultiSearchResponse> MultiSearchAsync(IMultiSearchRequest request, CancellationToken ct = default) => DoRequestAsync<IMultiSearchRequest, MultiSearchResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>msearch_template</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/">https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</a>
		/// </summary>
		public MultiSearchResponse MultiSearchTemplate(Indices index = null, Func<MultiSearchTemplateDescriptor, IMultiSearchTemplateRequest> selector = null) => MultiSearchTemplate(selector.InvokeOrDefault(new MultiSearchTemplateDescriptor().Index(index: index)));
		/// <summary>
		/// <c>POST</c> request to the <c>msearch_template</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/">https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</a>
		/// </summary>
		public Task<MultiSearchResponse> MultiSearchTemplateAsync(Indices index = null, Func<MultiSearchTemplateDescriptor, IMultiSearchTemplateRequest> selector = null, CancellationToken ct = default) => MultiSearchTemplateAsync(selector.InvokeOrDefault(new MultiSearchTemplateDescriptor().Index(index: index)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>msearch_template</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/">https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</a>
		/// </summary>
		public MultiSearchResponse MultiSearchTemplate(IMultiSearchTemplateRequest request) => DoRequest<IMultiSearchTemplateRequest, MultiSearchResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>msearch_template</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/">https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</a>
		/// </summary>
		public Task<MultiSearchResponse> MultiSearchTemplateAsync(IMultiSearchTemplateRequest request, CancellationToken ct = default) => DoRequestAsync<IMultiSearchTemplateRequest, MultiSearchResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>mtermvectors</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public MultiTermVectorsResponse MultiTermVectors(Func<MultiTermVectorsDescriptor, IMultiTermVectorsRequest> selector = null) => MultiTermVectors(selector.InvokeOrDefault(new MultiTermVectorsDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>mtermvectors</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<MultiTermVectorsResponse> MultiTermVectorsAsync(Func<MultiTermVectorsDescriptor, IMultiTermVectorsRequest> selector = null, CancellationToken ct = default) => MultiTermVectorsAsync(selector.InvokeOrDefault(new MultiTermVectorsDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>mtermvectors</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public MultiTermVectorsResponse MultiTermVectors(IMultiTermVectorsRequest request) => DoRequest<IMultiTermVectorsRequest, MultiTermVectorsResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>mtermvectors</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<MultiTermVectorsResponse> MultiTermVectorsAsync(IMultiTermVectorsRequest request, CancellationToken ct = default) => DoRequestAsync<IMultiTermVectorsRequest, MultiTermVectorsResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>HEAD</c> request to the <c>ping</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/index/">https://opensearch.org/docs/latest/opensearch/index/</a>
		/// </summary>
		public PingResponse Ping(Func<PingDescriptor, IPingRequest> selector = null) => Ping(selector.InvokeOrDefault(new PingDescriptor()));
		/// <summary>
		/// <c>HEAD</c> request to the <c>ping</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/index/">https://opensearch.org/docs/latest/opensearch/index/</a>
		/// </summary>
		public Task<PingResponse> PingAsync(Func<PingDescriptor, IPingRequest> selector = null, CancellationToken ct = default) => PingAsync(selector.InvokeOrDefault(new PingDescriptor()), ct);
		/// <summary>
		/// <c>HEAD</c> request to the <c>ping</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/index/">https://opensearch.org/docs/latest/opensearch/index/</a>
		/// </summary>
		public PingResponse Ping(IPingRequest request) => DoRequest<IPingRequest, PingResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>HEAD</c> request to the <c>ping</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/index/">https://opensearch.org/docs/latest/opensearch/index/</a>
		/// </summary>
		public Task<PingResponse> PingAsync(IPingRequest request, CancellationToken ct = default) => DoRequestAsync<IPingRequest, PingResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>put_script</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public PutScriptResponse PutScript(Id id, Func<PutScriptDescriptor, IPutScriptRequest> selector) => PutScript(selector.InvokeOrDefault(new PutScriptDescriptor(id: id)));
		/// <summary>
		/// <c>PUT</c> request to the <c>put_script</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<PutScriptResponse> PutScriptAsync(Id id, Func<PutScriptDescriptor, IPutScriptRequest> selector, CancellationToken ct = default) => PutScriptAsync(selector.InvokeOrDefault(new PutScriptDescriptor(id: id)), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>put_script</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public PutScriptResponse PutScript(IPutScriptRequest request) => DoRequest<IPutScriptRequest, PutScriptResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>put_script</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<PutScriptResponse> PutScriptAsync(IPutScriptRequest request, CancellationToken ct = default) => DoRequestAsync<IPutScriptRequest, PutScriptResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>reindex</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/</a>
		/// </summary>
		public ReindexOnServerResponse ReindexOnServer(Func<ReindexOnServerDescriptor, IReindexOnServerRequest> selector) => ReindexOnServer(selector.InvokeOrDefault(new ReindexOnServerDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>reindex</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/</a>
		/// </summary>
		public Task<ReindexOnServerResponse> ReindexOnServerAsync(Func<ReindexOnServerDescriptor, IReindexOnServerRequest> selector, CancellationToken ct = default) => ReindexOnServerAsync(selector.InvokeOrDefault(new ReindexOnServerDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>reindex</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/</a>
		/// </summary>
		public ReindexOnServerResponse ReindexOnServer(IReindexOnServerRequest request) => DoRequest<IReindexOnServerRequest, ReindexOnServerResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>reindex</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/</a>
		/// </summary>
		public Task<ReindexOnServerResponse> ReindexOnServerAsync(IReindexOnServerRequest request, CancellationToken ct = default) => DoRequestAsync<IReindexOnServerRequest, ReindexOnServerResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>reindex_rethrottle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/</a>
		/// </summary>
		public ReindexRethrottleResponse ReindexRethrottle(TaskId taskId, Func<ReindexRethrottleDescriptor, IReindexRethrottleRequest> selector = null) => ReindexRethrottle(selector.InvokeOrDefault(new ReindexRethrottleDescriptor(taskId: taskId)));
		/// <summary>
		/// <c>POST</c> request to the <c>reindex_rethrottle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/</a>
		/// </summary>
		public Task<ReindexRethrottleResponse> ReindexRethrottleAsync(TaskId taskId, Func<ReindexRethrottleDescriptor, IReindexRethrottleRequest> selector = null, CancellationToken ct = default) => ReindexRethrottleAsync(selector.InvokeOrDefault(new ReindexRethrottleDescriptor(taskId: taskId)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>reindex_rethrottle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/</a>
		/// </summary>
		public ReindexRethrottleResponse ReindexRethrottle(IReindexRethrottleRequest request) => DoRequest<IReindexRethrottleRequest, ReindexRethrottleResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>reindex_rethrottle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/</a>
		/// </summary>
		public Task<ReindexRethrottleResponse> ReindexRethrottleAsync(IReindexRethrottleRequest request, CancellationToken ct = default) => DoRequestAsync<IReindexRethrottleRequest, ReindexRethrottleResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>render_search_template</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/search-template/">https://opensearch.org/docs/latest/opensearch/search-template/</a>
		/// </summary>
		public RenderSearchTemplateResponse RenderSearchTemplate(Func<RenderSearchTemplateDescriptor, IRenderSearchTemplateRequest> selector = null) => RenderSearchTemplate(selector.InvokeOrDefault(new RenderSearchTemplateDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>render_search_template</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/search-template/">https://opensearch.org/docs/latest/opensearch/search-template/</a>
		/// </summary>
		public Task<RenderSearchTemplateResponse> RenderSearchTemplateAsync(Func<RenderSearchTemplateDescriptor, IRenderSearchTemplateRequest> selector = null, CancellationToken ct = default) => RenderSearchTemplateAsync(selector.InvokeOrDefault(new RenderSearchTemplateDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>render_search_template</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/search-template/">https://opensearch.org/docs/latest/opensearch/search-template/</a>
		/// </summary>
		public RenderSearchTemplateResponse RenderSearchTemplate(IRenderSearchTemplateRequest request) => DoRequest<IRenderSearchTemplateRequest, RenderSearchTemplateResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>render_search_template</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/search-template/">https://opensearch.org/docs/latest/opensearch/search-template/</a>
		/// </summary>
		public Task<RenderSearchTemplateResponse> RenderSearchTemplateAsync(IRenderSearchTemplateRequest request, CancellationToken ct = default) => DoRequestAsync<IRenderSearchTemplateRequest, RenderSearchTemplateResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>scripts_painless_execute</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public ExecutePainlessScriptResponse<TResult> ExecutePainlessScript<TResult>(Func<ExecutePainlessScriptDescriptor, IExecutePainlessScriptRequest> selector = null) => ExecutePainlessScript<TResult>(selector.InvokeOrDefault(new ExecutePainlessScriptDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>scripts_painless_execute</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<ExecutePainlessScriptResponse<TResult>> ExecutePainlessScriptAsync<TResult>(Func<ExecutePainlessScriptDescriptor, IExecutePainlessScriptRequest> selector = null, CancellationToken ct = default) => ExecutePainlessScriptAsync<TResult>(selector.InvokeOrDefault(new ExecutePainlessScriptDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>scripts_painless_execute</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public ExecutePainlessScriptResponse<TResult> ExecutePainlessScript<TResult>(IExecutePainlessScriptRequest request) => DoRequest<IExecutePainlessScriptRequest, ExecutePainlessScriptResponse<TResult>>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>scripts_painless_execute</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<ExecutePainlessScriptResponse<TResult>> ExecutePainlessScriptAsync<TResult>(IExecutePainlessScriptRequest request, CancellationToken ct = default) => DoRequestAsync<IExecutePainlessScriptRequest, ExecutePainlessScriptResponse<TResult>>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>scroll</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/search/#request-body">https://opensearch.org/docs/latest/opensearch/rest-api/search/#request-body</a>
		/// </summary>
		public ISearchResponse<TDocument> Scroll<TInferDocument, TDocument>(Time scroll, string scrollId, Func<ScrollDescriptor<TInferDocument>, IScrollRequest> selector = null)
			where TInferDocument : class where TDocument : class => Scroll<TDocument>(selector.InvokeOrDefault(new ScrollDescriptor<TInferDocument>(scroll, scrollId)));
		/// <summary>
		/// <c>POST</c> request to the <c>scroll</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/search/#request-body">https://opensearch.org/docs/latest/opensearch/rest-api/search/#request-body</a>
		/// </summary>
		public async Task<ISearchResponse<TDocument>> ScrollAsync<TInferDocument, TDocument>(Time scroll, string scrollId, Func<ScrollDescriptor<TInferDocument>, IScrollRequest> selector = null, CancellationToken ct = default)
			where TInferDocument : class where TDocument : class => await ScrollAsync<TDocument>(selector.InvokeOrDefault(new ScrollDescriptor<TInferDocument>(scroll, scrollId)), ct).ConfigureAwait(false);
		/// <summary>
		/// <c>POST</c> request to the <c>scroll</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/search/#request-body">https://opensearch.org/docs/latest/opensearch/rest-api/search/#request-body</a>
		/// </summary>
		public ISearchResponse<TDocument> Scroll<TDocument>(Time scroll, string scrollId, Func<ScrollDescriptor<TDocument>, IScrollRequest> selector = null)
			where TDocument : class => Scroll<TDocument>(selector.InvokeOrDefault(new ScrollDescriptor<TDocument>(scroll, scrollId)));
		/// <summary>
		/// <c>POST</c> request to the <c>scroll</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/search/#request-body">https://opensearch.org/docs/latest/opensearch/rest-api/search/#request-body</a>
		/// </summary>
		public async Task<ISearchResponse<TDocument>> ScrollAsync<TDocument>(Time scroll, string scrollId, Func<ScrollDescriptor<TDocument>, IScrollRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => await ScrollAsync<TDocument>(selector.InvokeOrDefault(new ScrollDescriptor<TDocument>(scroll, scrollId)), ct).ConfigureAwait(false);
		/// <summary>
		/// <c>POST</c> request to the <c>scroll</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/search/#request-body">https://opensearch.org/docs/latest/opensearch/rest-api/search/#request-body</a>
		/// </summary>
		public ISearchResponse<TDocument> Scroll<TDocument>(IScrollRequest request)
			where TDocument : class => DoRequest<IScrollRequest, SearchResponse<TDocument>>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>scroll</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/search/#request-body">https://opensearch.org/docs/latest/opensearch/rest-api/search/#request-body</a>
		/// </summary>
		public async Task<ISearchResponse<TDocument>> ScrollAsync<TDocument>(IScrollRequest request, CancellationToken ct = default)
			where TDocument : class => await DoRequestAsync<IScrollRequest, SearchResponse<TDocument>>(request, request.RequestParameters, ct).ConfigureAwait(false);
		/// <summary>
		/// <c>POST</c> request to the <c>search</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/search/">https://opensearch.org/docs/latest/opensearch/rest-api/search/</a>
		/// </summary>
		public ISearchResponse<TDocument> Search<TInferDocument, TDocument>(Func<SearchDescriptor<TInferDocument>, ISearchRequest> selector = null)
			where TInferDocument : class where TDocument : class => Search<TDocument>(selector.InvokeOrDefault(new SearchDescriptor<TInferDocument>()));
		/// <summary>
		/// <c>POST</c> request to the <c>search</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/search/">https://opensearch.org/docs/latest/opensearch/rest-api/search/</a>
		/// </summary>
		public async Task<ISearchResponse<TDocument>> SearchAsync<TInferDocument, TDocument>(Func<SearchDescriptor<TInferDocument>, ISearchRequest> selector = null, CancellationToken ct = default)
			where TInferDocument : class where TDocument : class => await SearchAsync<TDocument>(selector.InvokeOrDefault(new SearchDescriptor<TInferDocument>()), ct).ConfigureAwait(false);
		/// <summary>
		/// <c>POST</c> request to the <c>search</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/search/">https://opensearch.org/docs/latest/opensearch/rest-api/search/</a>
		/// </summary>
		public ISearchResponse<TDocument> Search<TDocument>(Func<SearchDescriptor<TDocument>, ISearchRequest> selector = null)
			where TDocument : class => Search<TDocument>(selector.InvokeOrDefault(new SearchDescriptor<TDocument>()));
		/// <summary>
		/// <c>POST</c> request to the <c>search</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/search/">https://opensearch.org/docs/latest/opensearch/rest-api/search/</a>
		/// </summary>
		public async Task<ISearchResponse<TDocument>> SearchAsync<TDocument>(Func<SearchDescriptor<TDocument>, ISearchRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => await SearchAsync<TDocument>(selector.InvokeOrDefault(new SearchDescriptor<TDocument>()), ct).ConfigureAwait(false);
		/// <summary>
		/// <c>POST</c> request to the <c>search</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/search/">https://opensearch.org/docs/latest/opensearch/rest-api/search/</a>
		/// </summary>
		public ISearchResponse<TDocument> Search<TDocument>(ISearchRequest request)
			where TDocument : class => DoRequest<ISearchRequest, SearchResponse<TDocument>>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>search</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/search/">https://opensearch.org/docs/latest/opensearch/rest-api/search/</a>
		/// </summary>
		public async Task<ISearchResponse<TDocument>> SearchAsync<TDocument>(ISearchRequest request, CancellationToken ct = default)
			where TDocument : class => await DoRequestAsync<ISearchRequest, SearchResponse<TDocument>>(request, request.RequestParameters, ct).ConfigureAwait(false);
		/// <summary>
		/// <c>POST</c> request to the <c>search_shards</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/security-plugin/access-control/cross-cluster-search/">https://opensearch.org/docs/latest/security-plugin/access-control/cross-cluster-search/</a>
		/// </summary>
		public SearchShardsResponse SearchShards<TDocument>(Func<SearchShardsDescriptor<TDocument>, ISearchShardsRequest> selector = null)
			where TDocument : class => SearchShards(selector.InvokeOrDefault(new SearchShardsDescriptor<TDocument>()));
		/// <summary>
		/// <c>POST</c> request to the <c>search_shards</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/security-plugin/access-control/cross-cluster-search/">https://opensearch.org/docs/latest/security-plugin/access-control/cross-cluster-search/</a>
		/// </summary>
		public Task<SearchShardsResponse> SearchShardsAsync<TDocument>(Func<SearchShardsDescriptor<TDocument>, ISearchShardsRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => SearchShardsAsync(selector.InvokeOrDefault(new SearchShardsDescriptor<TDocument>()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>search_shards</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/security-plugin/access-control/cross-cluster-search/">https://opensearch.org/docs/latest/security-plugin/access-control/cross-cluster-search/</a>
		/// </summary>
		public SearchShardsResponse SearchShards(ISearchShardsRequest request) => DoRequest<ISearchShardsRequest, SearchShardsResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>search_shards</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/security-plugin/access-control/cross-cluster-search/">https://opensearch.org/docs/latest/security-plugin/access-control/cross-cluster-search/</a>
		/// </summary>
		public Task<SearchShardsResponse> SearchShardsAsync(ISearchShardsRequest request, CancellationToken ct = default) => DoRequestAsync<ISearchShardsRequest, SearchShardsResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>search_template</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/search-template/">https://opensearch.org/docs/latest/opensearch/search-template/</a>
		/// </summary>
		public ISearchResponse<TDocument> SearchTemplate<TDocument>(Func<SearchTemplateDescriptor<TDocument>, ISearchTemplateRequest> selector = null)
			where TDocument : class => SearchTemplate<TDocument>(selector.InvokeOrDefault(new SearchTemplateDescriptor<TDocument>()));
		/// <summary>
		/// <c>POST</c> request to the <c>search_template</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/search-template/">https://opensearch.org/docs/latest/opensearch/search-template/</a>
		/// </summary>
		public async Task<ISearchResponse<TDocument>> SearchTemplateAsync<TDocument>(Func<SearchTemplateDescriptor<TDocument>, ISearchTemplateRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => await SearchTemplateAsync<TDocument>(selector.InvokeOrDefault(new SearchTemplateDescriptor<TDocument>()), ct).ConfigureAwait(false);
		/// <summary>
		/// <c>POST</c> request to the <c>search_template</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/search-template/">https://opensearch.org/docs/latest/opensearch/search-template/</a>
		/// </summary>
		public ISearchResponse<TDocument> SearchTemplate<TDocument>(ISearchTemplateRequest request)
			where TDocument : class => DoRequest<ISearchTemplateRequest, SearchResponse<TDocument>>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>search_template</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/search-template/">https://opensearch.org/docs/latest/opensearch/search-template/</a>
		/// </summary>
		public async Task<ISearchResponse<TDocument>> SearchTemplateAsync<TDocument>(ISearchTemplateRequest request, CancellationToken ct = default)
			where TDocument : class => await DoRequestAsync<ISearchTemplateRequest, SearchResponse<TDocument>>(request, request.RequestParameters, ct).ConfigureAwait(false);
		/// <summary>
		/// <c>POST</c> request to the <c>termvectors</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public TermVectorsResponse TermVectors<TDocument>(Func<TermVectorsDescriptor<TDocument>, ITermVectorsRequest<TDocument>> selector = null)
			where TDocument : class => TermVectors<TDocument>(selector.InvokeOrDefault(new TermVectorsDescriptor<TDocument>()));
		/// <summary>
		/// <c>POST</c> request to the <c>termvectors</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<TermVectorsResponse> TermVectorsAsync<TDocument>(Func<TermVectorsDescriptor<TDocument>, ITermVectorsRequest<TDocument>> selector = null, CancellationToken ct = default)
			where TDocument : class => TermVectorsAsync<TDocument>(selector.InvokeOrDefault(new TermVectorsDescriptor<TDocument>()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>termvectors</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public TermVectorsResponse TermVectors<TDocument>(ITermVectorsRequest<TDocument> request)
			where TDocument : class => DoRequest<ITermVectorsRequest<TDocument>, TermVectorsResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>termvectors</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<TermVectorsResponse> TermVectorsAsync<TDocument>(ITermVectorsRequest<TDocument> request, CancellationToken ct = default)
			where TDocument : class => DoRequestAsync<ITermVectorsRequest<TDocument>, TermVectorsResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>update</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-document/</a>
		/// </summary>
		public UpdateResponse<TDocument> Update<TDocument, TPartialDocument>(DocumentPath<TDocument> id, Func<UpdateDescriptor<TDocument, TPartialDocument>, IUpdateRequest<TDocument, TPartialDocument>> selector)
			where TDocument : class where TPartialDocument : class => Update<TDocument, TPartialDocument>(selector.InvokeOrDefault(new UpdateDescriptor<TDocument, TPartialDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)));
		/// <summary>
		/// <c>POST</c> request to the <c>update</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-document/</a>
		/// </summary>
		public Task<UpdateResponse<TDocument>> UpdateAsync<TDocument, TPartialDocument>(DocumentPath<TDocument> id, Func<UpdateDescriptor<TDocument, TPartialDocument>, IUpdateRequest<TDocument, TPartialDocument>> selector, CancellationToken ct = default)
			where TDocument : class where TPartialDocument : class => UpdateAsync<TDocument, TPartialDocument>(selector.InvokeOrDefault(new UpdateDescriptor<TDocument, TPartialDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>update</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-document/</a>
		/// </summary>
		public UpdateResponse<TDocument> Update<TDocument>(DocumentPath<TDocument> id, Func<UpdateDescriptor<TDocument, TDocument>, IUpdateRequest<TDocument, TDocument>> selector)
			where TDocument : class => Update<TDocument, TDocument>(selector.InvokeOrDefault(new UpdateDescriptor<TDocument, TDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)));
		/// <summary>
		/// <c>POST</c> request to the <c>update</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-document/</a>
		/// </summary>
		public Task<UpdateResponse<TDocument>> UpdateAsync<TDocument>(DocumentPath<TDocument> id, Func<UpdateDescriptor<TDocument, TDocument>, IUpdateRequest<TDocument, TDocument>> selector, CancellationToken ct = default)
			where TDocument : class => UpdateAsync<TDocument, TDocument>(selector.InvokeOrDefault(new UpdateDescriptor<TDocument, TDocument>(documentWithId: id?.Document, index: id?.Self?.Index, id: id?.Self?.Id)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>update</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-document/</a>
		/// </summary>
		public UpdateResponse<TDocument> Update<TDocument, TPartialDocument>(IUpdateRequest<TDocument, TPartialDocument> request)
			where TDocument : class where TPartialDocument : class => DoRequest<IUpdateRequest<TDocument, TPartialDocument>, UpdateResponse<TDocument>>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>update</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-document/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-document/</a>
		/// </summary>
		public Task<UpdateResponse<TDocument>> UpdateAsync<TDocument, TPartialDocument>(IUpdateRequest<TDocument, TPartialDocument> request, CancellationToken ct = default)
			where TDocument : class where TPartialDocument : class => DoRequestAsync<IUpdateRequest<TDocument, TPartialDocument>, UpdateResponse<TDocument>>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>update_by_query</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/</a>
		/// </summary>
		public UpdateByQueryResponse UpdateByQuery<TDocument>(Func<UpdateByQueryDescriptor<TDocument>, IUpdateByQueryRequest> selector = null)
			where TDocument : class => UpdateByQuery(selector.InvokeOrDefault(new UpdateByQueryDescriptor<TDocument>()));
		/// <summary>
		/// <c>POST</c> request to the <c>update_by_query</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/</a>
		/// </summary>
		public Task<UpdateByQueryResponse> UpdateByQueryAsync<TDocument>(Func<UpdateByQueryDescriptor<TDocument>, IUpdateByQueryRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => UpdateByQueryAsync(selector.InvokeOrDefault(new UpdateByQueryDescriptor<TDocument>()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>update_by_query</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/</a>
		/// </summary>
		public UpdateByQueryResponse UpdateByQuery(IUpdateByQueryRequest request) => DoRequest<IUpdateByQueryRequest, UpdateByQueryResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>update_by_query</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/</a>
		/// </summary>
		public Task<UpdateByQueryResponse> UpdateByQueryAsync(IUpdateByQueryRequest request, CancellationToken ct = default) => DoRequestAsync<IUpdateByQueryRequest, UpdateByQueryResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>update_by_query_rethrottle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/</a>
		/// </summary>
		public ListTasksResponse UpdateByQueryRethrottle(TaskId taskId, Func<UpdateByQueryRethrottleDescriptor, IUpdateByQueryRethrottleRequest> selector = null) => UpdateByQueryRethrottle(selector.InvokeOrDefault(new UpdateByQueryRethrottleDescriptor(taskId: taskId)));
		/// <summary>
		/// <c>POST</c> request to the <c>update_by_query_rethrottle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/</a>
		/// </summary>
		public Task<ListTasksResponse> UpdateByQueryRethrottleAsync(TaskId taskId, Func<UpdateByQueryRethrottleDescriptor, IUpdateByQueryRethrottleRequest> selector = null, CancellationToken ct = default) => UpdateByQueryRethrottleAsync(selector.InvokeOrDefault(new UpdateByQueryRethrottleDescriptor(taskId: taskId)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>update_by_query_rethrottle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/</a>
		/// </summary>
		public ListTasksResponse UpdateByQueryRethrottle(IUpdateByQueryRethrottleRequest request) => DoRequest<IUpdateByQueryRethrottleRequest, ListTasksResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>update_by_query_rethrottle</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/">https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/</a>
		/// </summary>
		public Task<ListTasksResponse> UpdateByQueryRethrottleAsync(IUpdateByQueryRethrottleRequest request, CancellationToken ct = default) => DoRequestAsync<IUpdateByQueryRethrottleRequest, ListTasksResponse>(request, request.RequestParameters, ct);
	}
}
