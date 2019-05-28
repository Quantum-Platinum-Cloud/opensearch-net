﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.Indices.Analyze
{
	public class AnalyzeUrlTests
	{
		[U] public async Task Urls()
		{
			var hardcoded = "hardcoded";
			var index = "index";
			await POST($"/{index}/_analyze")
					.Fluent(c => c.Indices.Analyze(a => a.Text(hardcoded).Index(index)))
					.Request(c => c.Indices.Analyze(new AnalyzeRequest(index, hardcoded)))
					.FluentAsync(c => c.Indices.AnalyzeAsync(a => a.Text(hardcoded).Index(index)))
					.RequestAsync(c => c.Indices.AnalyzeAsync(new AnalyzeRequest(index, hardcoded)))
				;

			await POST($"/_analyze")
					.Fluent(c => c.Indices.Analyze(a => a.Text(hardcoded)))
					.Request(c => c.Indices.Analyze(new AnalyzeRequest() { Text = new[] { hardcoded } }))
					.FluentAsync(c => c.Indices.AnalyzeAsync(a => a.Text(hardcoded)))
					.RequestAsync(c => c.Indices.AnalyzeAsync(new AnalyzeRequest() { Text = new[] { hardcoded } }))
				;
		}
	}
}
