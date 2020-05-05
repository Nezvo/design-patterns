using System;

namespace GangOfFour.Visitor
{
	public class PlainTextVisitor : IVisitor
	{
		public void Apply(HeadingNode heading) => Console.WriteLine("text-heading");

		public void Apply(AnchorNode anchor) => Console.WriteLine("teaxt-anchor");
	}
}
