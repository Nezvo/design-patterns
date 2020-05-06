namespace GangOfFour.Flyweight
{
	public class Point
	{
		private readonly double x;
		private readonly double y;
		private readonly PointIcon pointIcon;

		public Point(double x, double y, PointIcon pointIcon)
		{
			this.x = x;
			this.y = y;
			this.pointIcon = pointIcon;
		}

		public void Draw() => System.Console.WriteLine($"{pointIcon.Type} at ({x}, {y})");
	}
}
