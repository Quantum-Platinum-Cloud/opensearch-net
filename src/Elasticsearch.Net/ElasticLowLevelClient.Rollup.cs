// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using static Elasticsearch.Net.HttpMethod;

// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable once CheckNamespace
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable RedundantExtendsListEntry
namespace Elasticsearch.Net.Specification.RollupApi
{
	///<summary>
	/// Rollup APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticLowLevelClient.Rollup"/> property
	/// on <see cref = "IElasticLowLevelClient"/>.
	///</para>
	///</summary>
	public partial class LowLevelRollupNamespace : NamespacedClientProxy
	{
		internal LowLevelRollupNamespace(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>DELETE on /_rollup/job/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-delete-job.html</para></summary>
		///<param name = "id">The ID of the job to delete</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse DeleteJob<TResponse>(string id, DeleteRollupJobRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(DELETE, Url($"_rollup/job/{id:id}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_rollup/job/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-delete-job.html</para></summary>
		///<param name = "id">The ID of the job to delete</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("rollup.delete_job", "id")]
		public Task<TResponse> DeleteJobAsync<TResponse>(string id, DeleteRollupJobRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_rollup/job/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_rollup/job/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-get-job.html</para></summary>
		///<param name = "id">The ID of the job(s) to fetch. Accepts glob patterns, or left blank for all jobs</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse GetJob<TResponse>(string id, GetRollupJobRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, Url($"_rollup/job/{id:id}"), null, RequestParams(requestParameters));
		///<summary>GET on /_rollup/job/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-get-job.html</para></summary>
		///<param name = "id">The ID of the job(s) to fetch. Accepts glob patterns, or left blank for all jobs</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("rollup.get_jobs", "id")]
		public Task<TResponse> GetJobAsync<TResponse>(string id, GetRollupJobRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_rollup/job/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_rollup/job/ <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-get-job.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse GetJob<TResponse>(GetRollupJobRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, "_rollup/job/", null, RequestParams(requestParameters));
		///<summary>GET on /_rollup/job/ <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-get-job.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("rollup.get_jobs", "")]
		public Task<TResponse> GetJobAsync<TResponse>(GetRollupJobRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, "_rollup/job/", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_rollup/data/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-get-rollup-caps.html</para></summary>
		///<param name = "id">The ID of the index to check rollup capabilities on, or left blank for all jobs</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse GetCapabilities<TResponse>(string id, GetRollupCapabilitiesRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, Url($"_rollup/data/{id:id}"), null, RequestParams(requestParameters));
		///<summary>GET on /_rollup/data/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-get-rollup-caps.html</para></summary>
		///<param name = "id">The ID of the index to check rollup capabilities on, or left blank for all jobs</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("rollup.get_rollup_caps", "id")]
		public Task<TResponse> GetCapabilitiesAsync<TResponse>(string id, GetRollupCapabilitiesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_rollup/data/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_rollup/data/ <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-get-rollup-caps.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse GetCapabilities<TResponse>(GetRollupCapabilitiesRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, "_rollup/data/", null, RequestParams(requestParameters));
		///<summary>GET on /_rollup/data/ <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-get-rollup-caps.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("rollup.get_rollup_caps", "")]
		public Task<TResponse> GetCapabilitiesAsync<TResponse>(GetRollupCapabilitiesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, "_rollup/data/", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_rollup/data <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-get-rollup-index-caps.html</para></summary>
		///<param name = "index">The rollup index or index pattern to obtain rollup capabilities from.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse GetIndexCapabilities<TResponse>(string index, GetRollupIndexCapabilitiesRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}/_rollup/data"), null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_rollup/data <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-get-rollup-index-caps.html</para></summary>
		///<param name = "index">The rollup index or index pattern to obtain rollup capabilities from.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("rollup.get_rollup_index_caps", "index")]
		public Task<TResponse> GetIndexCapabilitiesAsync<TResponse>(string index, GetRollupIndexCapabilitiesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}/_rollup/data"), ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /_rollup/job/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-put-job.html</para></summary>
		///<param name = "id">The ID of the job to create</param>
		///<param name = "body">The job configuration</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse CreateJob<TResponse>(string id, PostData body, CreateRollupJobRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(PUT, Url($"_rollup/job/{id:id}"), body, RequestParams(requestParameters));
		///<summary>PUT on /_rollup/job/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-put-job.html</para></summary>
		///<param name = "id">The ID of the job to create</param>
		///<param name = "body">The job configuration</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("rollup.put_job", "id, body")]
		public Task<TResponse> CreateJobAsync<TResponse>(string id, PostData body, CreateRollupJobRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_rollup/job/{id:id}"), ctx, body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_rollup/{rollup_index} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-api.html</para></summary>
		///<param name = "index">The index to roll up</param>
		///<param name = "rollupIndex">The name of the rollup index to create</param>
		///<param name = "body">The rollup configuration</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Rollup<TResponse>(string index, string rollupIndex, PostData body, RollupRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_rollup/{rollupIndex:rollupIndex}"), body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_rollup/{rollup_index} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-api.html</para></summary>
		///<param name = "index">The index to roll up</param>
		///<param name = "rollupIndex">The name of the rollup index to create</param>
		///<param name = "body">The rollup configuration</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("rollup.rollup", "index, rollup_index, body")]
		public Task<TResponse> RollupAsync<TResponse>(string index, string rollupIndex, PostData body, RollupRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_rollup/{rollupIndex:rollupIndex}"), ctx, body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_rollup_search <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-search.html</para></summary>
		///<param name = "index">The indices or index-pattern(s) (containing rollup or regular data) that should be searched</param>
		///<param name = "body">The search request body</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse Search<TResponse>(string index, PostData body, RollupSearchRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_rollup_search"), body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_rollup_search <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-search.html</para></summary>
		///<param name = "index">The indices or index-pattern(s) (containing rollup or regular data) that should be searched</param>
		///<param name = "body">The search request body</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("rollup.rollup_search", "index, body")]
		public Task<TResponse> SearchAsync<TResponse>(string index, PostData body, RollupSearchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_rollup_search"), ctx, body, RequestParams(requestParameters));
		///<summary>POST on /{index}/{type}/_rollup_search <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-search.html</para></summary>
		///<param name = "index">The indices or index-pattern(s) (containing rollup or regular data) that should be searched</param>
		///<param name = "type">The doc type inside the index</param>
		///<param name = "body">The search request body</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[Obsolete("Deprecated in version 7.0.0: Specifying types in urls has been deprecated")]
		public TResponse SearchUsingType<TResponse>(string index, string type, PostData body, RollupSearchRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/{type:type}/_rollup_search"), body, RequestParams(requestParameters));
		///<summary>POST on /{index}/{type}/_rollup_search <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-search.html</para></summary>
		///<param name = "index">The indices or index-pattern(s) (containing rollup or regular data) that should be searched</param>
		///<param name = "type">The doc type inside the index</param>
		///<param name = "body">The search request body</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[Obsolete("Deprecated in version 7.0.0: Specifying types in urls has been deprecated")]
		[MapsApi("rollup.rollup_search", "index, type, body")]
		public Task<TResponse> SearchUsingTypeAsync<TResponse>(string index, string type, PostData body, RollupSearchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/{type:type}/_rollup_search"), ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_rollup/job/{id}/_start <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-start-job.html</para></summary>
		///<param name = "id">The ID of the job to start</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse StartJob<TResponse>(string id, StartRollupJobRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, Url($"_rollup/job/{id:id}/_start"), null, RequestParams(requestParameters));
		///<summary>POST on /_rollup/job/{id}/_start <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-start-job.html</para></summary>
		///<param name = "id">The ID of the job to start</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("rollup.start_job", "id")]
		public Task<TResponse> StartJobAsync<TResponse>(string id, StartRollupJobRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"_rollup/job/{id:id}/_start"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_rollup/job/{id}/_stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-stop-job.html</para></summary>
		///<param name = "id">The ID of the job to stop</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse StopJob<TResponse>(string id, StopRollupJobRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, Url($"_rollup/job/{id:id}/_stop"), null, RequestParams(requestParameters));
		///<summary>POST on /_rollup/job/{id}/_stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/rollup-stop-job.html</para></summary>
		///<param name = "id">The ID of the job to stop</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the Elasticsearch server, this functionality is Experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("rollup.stop_job", "id")]
		public Task<TResponse> StopJobAsync<TResponse>(string id, StopRollupJobRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"_rollup/job/{id:id}/_stop"), ctx, null, RequestParams(requestParameters));
	}
}