﻿using Elasticsearch.Net;
using FluentAssertions;
using Nest;
using Tests.Core.ManagedElasticsearch.Clusters;
using Tests.Framework;
using Tests.Framework.Integration;

namespace Tests.Cat.CatPlugins
{
	public class CatPluginsApiTests
		: ApiIntegrationTestBase<ReadOnlyCluster, CatResponse<CatPluginsRecord>, ICatPluginsRequest, CatPluginsDescriptor, CatPluginsRequest>
	{
		public CatPluginsApiTests(ReadOnlyCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override bool ExpectIsValid => true;
		protected override int ExpectStatusCode => 200;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override string UrlPath => "/_cat/plugins";

		protected override LazyResponses ClientUsage() => Calls(
			(client, f) => client.Cat.Plugins(),
			(client, f) => client.Cat.PluginsAsync(),
			(client, r) => client.Cat.Plugins(r),
			(client, r) => client.Cat.PluginsAsync(r)
		);

		protected override void ExpectResponse(CatResponse<CatPluginsRecord> response) => response.Records.Should()
			.NotBeEmpty()
			.And.Contain(a => !string.IsNullOrEmpty(a.Name) && a.Component == "mapper-murmur3");
	}
}
