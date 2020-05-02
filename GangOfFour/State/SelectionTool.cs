using System;

namespace GangOfFour.State
{
	/// <summary>
	/// Concrete state
	/// </summary>
	public class SelectionTool : ITool
	{
		public void MouseDown() => Console.WriteLine("Selection icon");

		public void MouseUp() =>	Console.WriteLine("Draw dashed rectangle");
	}
}
