namespace GangOfFour.Visitor
{
	public interface IHtmlNode
	{
		void Execute(IVisitor visitor);
	}
}
