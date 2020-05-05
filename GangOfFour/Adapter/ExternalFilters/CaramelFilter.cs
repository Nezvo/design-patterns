using System;
using System.Linq.Expressions;

namespace GangOfFour.Adapter.ExternalFilters
{
	/// <summary>
	/// External library
	/// </summary>
	public class CaramelFilter
	{
		public void Init() => Expression.Empty();

		public void Render(Image image) => Console.WriteLine("Applying caramel filter");
	}
}
