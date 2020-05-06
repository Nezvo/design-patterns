using System.Collections.Generic;

namespace GangOfFour.Flyweight
{
	public class PointIconFactory
	{
		private readonly Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();

		public PointIcon GetPointIcon(PointType type)
		{
			PointIcon icon;
			if (icons.ContainsKey(type))
				icon = icons[type];
			else
			{
				icon = new PointIcon(type, null);
				icons.Add(type, icon);
			}

			return icon;
		}
	}
}
