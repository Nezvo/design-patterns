using System;

namespace GangOfFour.Composite
{
	public class Shape : IComponent
	{
		public void Render() => Console.WriteLine("Render shape");

		public void Move() => Console.WriteLine("Moved shape");
	}
}
