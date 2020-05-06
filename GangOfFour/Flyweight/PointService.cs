using System.Collections.Generic;

namespace GangOfFour.Flyweight
{
	public class PointService
	{
		private readonly PointIconFactory pointIconFactory;

		public PointService(PointIconFactory pointIconFactory)
		{
			this.pointIconFactory = pointIconFactory;
		}

		public List<Point> GetPoints() => new List<Point> { new Point(1, 2, pointIconFactory.GetPointIcon(PointType.Caffe)) };
	}
}
