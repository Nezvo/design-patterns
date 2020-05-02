using System;

namespace GangOfFour.State
{
	/// <summary>
	/// Concrete state
	/// </summary>
	public class EraserTool : ITool
	{
		public void MouseDown() => Console.WriteLine("Eraser icon");

		public void MouseUp() =>	Console.WriteLine("Erase something");
	}
}
