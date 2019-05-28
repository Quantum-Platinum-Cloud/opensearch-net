﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.Indices.AliasManagement.AliasExists
{
	public class AliasExistsUrlTests
	{
		[U] public async Task Urls()
		{
			Name name = "hardcoded";
			IndexName index = "index";
			await HEAD($"/_alias/hardcoded")
					.Fluent(c => c.Indices.AliasExists(name))
					.Request(c => c.Indices.AliasExists(new AliasExistsRequest(name)))
					.FluentAsync(c => c.Indices.AliasExistsAsync(name))
					.RequestAsync(c => c.Indices.AliasExistsAsync(new AliasExistsRequest(name)))
				;

			await HEAD($"/index/_alias/hardcoded")
					.Fluent(c => c.Indices.AliasExists(name, b => b.Index(index)))
					.Request(c => c.Indices.AliasExists(new AliasExistsRequest(index, name)))
					.FluentAsync(c => c.Indices.AliasExistsAsync(name, b => b.Index(index)))
					.RequestAsync(c => c.Indices.AliasExistsAsync(new AliasExistsRequest(index, name)))
				;
		}
	}
}
