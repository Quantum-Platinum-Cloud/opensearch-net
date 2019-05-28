using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.IndexLifecycleManagementApi;

//This file is automatically generated from https://github.com/elastic/elasticsearch/tree/master/rest-api-spec
// ReSharper disable once CheckNamespace
namespace Nest.Specification.IndexLifecycleManagementApi
{
	///<summary>
	/// Logically groups all IndexLifecycleManagement API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticClient.IndexLifecycleManagement"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class IndexLifecycleManagementNamespace : NamespacedClientProxy
	{
		internal IndexLifecycleManagementNamespace(ElasticClient client): base(client)
		{
		}

		///<inheritdoc cref = "IDeleteLifecycleRequest"/>
		public DeleteLifecycleResponse DeleteLifecycle(PolicyId policyId, Func<DeleteLifecycleDescriptor, IDeleteLifecycleRequest> selector = null) => DeleteLifecycle(selector.InvokeOrDefault(new DeleteLifecycleDescriptor(policyId: policyId)));
		///<inheritdoc cref = "IDeleteLifecycleRequest"/>
		public Task<DeleteLifecycleResponse> DeleteLifecycleAsync(PolicyId policyId, Func<DeleteLifecycleDescriptor, IDeleteLifecycleRequest> selector = null, CancellationToken ct = default) => DeleteLifecycleAsync(selector.InvokeOrDefault(new DeleteLifecycleDescriptor(policyId: policyId)), ct);
		///<inheritdoc cref = "IDeleteLifecycleRequest"/>
		public DeleteLifecycleResponse DeleteLifecycle(IDeleteLifecycleRequest request) => DoRequest<IDeleteLifecycleRequest, DeleteLifecycleResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IDeleteLifecycleRequest"/>
		public Task<DeleteLifecycleResponse> DeleteLifecycleAsync(IDeleteLifecycleRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteLifecycleRequest, DeleteLifecycleResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IExplainLifecycleRequest"/>
		public ExplainLifecycleResponse ExplainLifecycle(IndexName index, Func<ExplainLifecycleDescriptor, IExplainLifecycleRequest> selector = null) => ExplainLifecycle(selector.InvokeOrDefault(new ExplainLifecycleDescriptor(index: index)));
		///<inheritdoc cref = "IExplainLifecycleRequest"/>
		public Task<ExplainLifecycleResponse> ExplainLifecycleAsync(IndexName index, Func<ExplainLifecycleDescriptor, IExplainLifecycleRequest> selector = null, CancellationToken ct = default) => ExplainLifecycleAsync(selector.InvokeOrDefault(new ExplainLifecycleDescriptor(index: index)), ct);
		///<inheritdoc cref = "IExplainLifecycleRequest"/>
		public ExplainLifecycleResponse ExplainLifecycle(IExplainLifecycleRequest request) => DoRequest<IExplainLifecycleRequest, ExplainLifecycleResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IExplainLifecycleRequest"/>
		public Task<ExplainLifecycleResponse> ExplainLifecycleAsync(IExplainLifecycleRequest request, CancellationToken ct = default) => DoRequestAsync<IExplainLifecycleRequest, ExplainLifecycleResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IGetLifecycleRequest"/>
		public GetLifecycleResponse GetLifecycle(Func<GetLifecycleDescriptor, IGetLifecycleRequest> selector = null) => GetLifecycle(selector.InvokeOrDefault(new GetLifecycleDescriptor()));
		///<inheritdoc cref = "IGetLifecycleRequest"/>
		public Task<GetLifecycleResponse> GetLifecycleAsync(Func<GetLifecycleDescriptor, IGetLifecycleRequest> selector = null, CancellationToken ct = default) => GetLifecycleAsync(selector.InvokeOrDefault(new GetLifecycleDescriptor()), ct);
		///<inheritdoc cref = "IGetLifecycleRequest"/>
		public GetLifecycleResponse GetLifecycle(IGetLifecycleRequest request) => DoRequest<IGetLifecycleRequest, GetLifecycleResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IGetLifecycleRequest"/>
		public Task<GetLifecycleResponse> GetLifecycleAsync(IGetLifecycleRequest request, CancellationToken ct = default) => DoRequestAsync<IGetLifecycleRequest, GetLifecycleResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IGetIlmStatusRequest"/>
		public GetIlmStatusResponse GetIlmStatus(Func<GetIlmStatusDescriptor, IGetIlmStatusRequest> selector = null) => GetIlmStatus(selector.InvokeOrDefault(new GetIlmStatusDescriptor()));
		///<inheritdoc cref = "IGetIlmStatusRequest"/>
		public Task<GetIlmStatusResponse> GetIlmStatusAsync(Func<GetIlmStatusDescriptor, IGetIlmStatusRequest> selector = null, CancellationToken ct = default) => GetIlmStatusAsync(selector.InvokeOrDefault(new GetIlmStatusDescriptor()), ct);
		///<inheritdoc cref = "IGetIlmStatusRequest"/>
		public GetIlmStatusResponse GetIlmStatus(IGetIlmStatusRequest request) => DoRequest<IGetIlmStatusRequest, GetIlmStatusResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IGetIlmStatusRequest"/>
		public Task<GetIlmStatusResponse> GetIlmStatusAsync(IGetIlmStatusRequest request, CancellationToken ct = default) => DoRequestAsync<IGetIlmStatusRequest, GetIlmStatusResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IMoveToStepRequest"/>
		public MoveToStepResponse MoveToStep(IndexName index, Func<MoveToStepDescriptor, IMoveToStepRequest> selector = null) => MoveToStep(selector.InvokeOrDefault(new MoveToStepDescriptor(index: index)));
		///<inheritdoc cref = "IMoveToStepRequest"/>
		public Task<MoveToStepResponse> MoveToStepAsync(IndexName index, Func<MoveToStepDescriptor, IMoveToStepRequest> selector = null, CancellationToken ct = default) => MoveToStepAsync(selector.InvokeOrDefault(new MoveToStepDescriptor(index: index)), ct);
		///<inheritdoc cref = "IMoveToStepRequest"/>
		public MoveToStepResponse MoveToStep(IMoveToStepRequest request) => DoRequest<IMoveToStepRequest, MoveToStepResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IMoveToStepRequest"/>
		public Task<MoveToStepResponse> MoveToStepAsync(IMoveToStepRequest request, CancellationToken ct = default) => DoRequestAsync<IMoveToStepRequest, MoveToStepResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IPutLifecycleRequest"/>
		public PutLifecycleResponse PutLifecycle(PolicyId policyId, Func<PutLifecycleDescriptor, IPutLifecycleRequest> selector = null) => PutLifecycle(selector.InvokeOrDefault(new PutLifecycleDescriptor(policyId: policyId)));
		///<inheritdoc cref = "IPutLifecycleRequest"/>
		public Task<PutLifecycleResponse> PutLifecycleAsync(PolicyId policyId, Func<PutLifecycleDescriptor, IPutLifecycleRequest> selector = null, CancellationToken ct = default) => PutLifecycleAsync(selector.InvokeOrDefault(new PutLifecycleDescriptor(policyId: policyId)), ct);
		///<inheritdoc cref = "IPutLifecycleRequest"/>
		public PutLifecycleResponse PutLifecycle(IPutLifecycleRequest request) => DoRequest<IPutLifecycleRequest, PutLifecycleResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IPutLifecycleRequest"/>
		public Task<PutLifecycleResponse> PutLifecycleAsync(IPutLifecycleRequest request, CancellationToken ct = default) => DoRequestAsync<IPutLifecycleRequest, PutLifecycleResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IRemovePolicyRequest"/>
		public RemovePolicyResponse RemovePolicy(IndexName index, Func<RemovePolicyDescriptor, IRemovePolicyRequest> selector = null) => RemovePolicy(selector.InvokeOrDefault(new RemovePolicyDescriptor(index: index)));
		///<inheritdoc cref = "IRemovePolicyRequest"/>
		public Task<RemovePolicyResponse> RemovePolicyAsync(IndexName index, Func<RemovePolicyDescriptor, IRemovePolicyRequest> selector = null, CancellationToken ct = default) => RemovePolicyAsync(selector.InvokeOrDefault(new RemovePolicyDescriptor(index: index)), ct);
		///<inheritdoc cref = "IRemovePolicyRequest"/>
		public RemovePolicyResponse RemovePolicy(IRemovePolicyRequest request) => DoRequest<IRemovePolicyRequest, RemovePolicyResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IRemovePolicyRequest"/>
		public Task<RemovePolicyResponse> RemovePolicyAsync(IRemovePolicyRequest request, CancellationToken ct = default) => DoRequestAsync<IRemovePolicyRequest, RemovePolicyResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IRetryIlmRequest"/>
		public RetryIlmResponse RetryIlm(IndexName index, Func<RetryIlmDescriptor, IRetryIlmRequest> selector = null) => RetryIlm(selector.InvokeOrDefault(new RetryIlmDescriptor(index: index)));
		///<inheritdoc cref = "IRetryIlmRequest"/>
		public Task<RetryIlmResponse> RetryIlmAsync(IndexName index, Func<RetryIlmDescriptor, IRetryIlmRequest> selector = null, CancellationToken ct = default) => RetryIlmAsync(selector.InvokeOrDefault(new RetryIlmDescriptor(index: index)), ct);
		///<inheritdoc cref = "IRetryIlmRequest"/>
		public RetryIlmResponse RetryIlm(IRetryIlmRequest request) => DoRequest<IRetryIlmRequest, RetryIlmResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IRetryIlmRequest"/>
		public Task<RetryIlmResponse> RetryIlmAsync(IRetryIlmRequest request, CancellationToken ct = default) => DoRequestAsync<IRetryIlmRequest, RetryIlmResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IStartIlmRequest"/>
		public StartIlmResponse StartIlm(Func<StartIlmDescriptor, IStartIlmRequest> selector = null) => StartIlm(selector.InvokeOrDefault(new StartIlmDescriptor()));
		///<inheritdoc cref = "IStartIlmRequest"/>
		public Task<StartIlmResponse> StartIlmAsync(Func<StartIlmDescriptor, IStartIlmRequest> selector = null, CancellationToken ct = default) => StartIlmAsync(selector.InvokeOrDefault(new StartIlmDescriptor()), ct);
		///<inheritdoc cref = "IStartIlmRequest"/>
		public StartIlmResponse StartIlm(IStartIlmRequest request) => DoRequest<IStartIlmRequest, StartIlmResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IStartIlmRequest"/>
		public Task<StartIlmResponse> StartIlmAsync(IStartIlmRequest request, CancellationToken ct = default) => DoRequestAsync<IStartIlmRequest, StartIlmResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IStopIlmRequest"/>
		public StopIlmResponse StopIlm(Func<StopIlmDescriptor, IStopIlmRequest> selector = null) => StopIlm(selector.InvokeOrDefault(new StopIlmDescriptor()));
		///<inheritdoc cref = "IStopIlmRequest"/>
		public Task<StopIlmResponse> StopIlmAsync(Func<StopIlmDescriptor, IStopIlmRequest> selector = null, CancellationToken ct = default) => StopIlmAsync(selector.InvokeOrDefault(new StopIlmDescriptor()), ct);
		///<inheritdoc cref = "IStopIlmRequest"/>
		public StopIlmResponse StopIlm(IStopIlmRequest request) => DoRequest<IStopIlmRequest, StopIlmResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IStopIlmRequest"/>
		public Task<StopIlmResponse> StopIlmAsync(IStopIlmRequest request, CancellationToken ct = default) => DoRequestAsync<IStopIlmRequest, StopIlmResponse>(request, request.RequestParameters, ct);
	}
}