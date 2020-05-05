namespace GangOfFour.Visitor
{
	public interface IVisitor
	{
		void Apply(HeadingNode heading);
		void Apply(AnchorNode anchor);
	}
}
