namespace GangOfFour.Flyweight
{
	/// <summary>
	/// Flyweight, object that we can share across
	/// </summary>
	public class PointIcon
	{
		private readonly byte[] icon;

		public PointType Type { get; }

		public PointIcon(PointType type, byte[] icon)
		{
			this.Type = type;
			this.icon = icon;
		}
	}
}
