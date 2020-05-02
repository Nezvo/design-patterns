using System;

namespace GangOfFour.State
{
	/// <summary>
	/// Concrete state
	/// </summary>
	public class BrushTool : ITool
	{
		public void MouseDown() => Console.WriteLine("Brush icon");

		public void MouseUp() =>	Console.WriteLine("Draw a line");
	}
}
