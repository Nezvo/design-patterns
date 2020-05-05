using System.Collections.Generic;

namespace GangOfFour.Visitor
{
	public class HtmlDocument
	{
		private readonly List<IHtmlNode> nodes = new List<IHtmlNode>();

		public void AddNode(IHtmlNode node) => nodes.Add(node);

		public void Execute(IVisitor visitor) => nodes.ForEach(node => node.Execute(visitor));
	}
}
