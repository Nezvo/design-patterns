﻿namespace GangOfFour.Visitor
{
	public class HeadingNode : IHtmlNode
	{
		public void Execute(IVisitor visitor) => visitor.Apply(this);
	}
}
