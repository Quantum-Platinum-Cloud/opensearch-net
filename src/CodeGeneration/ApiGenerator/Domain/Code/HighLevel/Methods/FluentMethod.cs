using System.Collections.Generic;
using System.Linq;
using ApiGenerator.Domain.Specification;

namespace ApiGenerator.Domain.Code.HighLevel.Methods 
{
	public class FluentMethod : FluentSyntaxBase
	{
		public FluentMethod(CsharpNames names, IReadOnlyCollection<UrlPart> parts, bool selectorIsOptional) : base(names, parts, selectorIsOptional) { }

		public override string GenericWhereClause =>
			string.Join(" ", CsharpNames.HighLevelDescriptorMethodGenerics
				.Where(g => g.Contains("Document"))
				.Select(g => $"where {g} : class")
			);
	}
}