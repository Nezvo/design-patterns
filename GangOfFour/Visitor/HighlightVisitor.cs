using System;

namespace GangOfFour.Visitor
{
	class HighlightVisitor : IVisitor
	{
		public void Apply(HeadingNode heading) => Console.WriteLine("highlight-heading");

		public void Apply(AnchorNode anchor) => Console.WriteLine("highlight-anchor");
	}
}
