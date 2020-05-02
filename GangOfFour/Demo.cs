using GangOfFour.Memento;
using GangOfFour.State;
using System;

namespace GangOfFour
{
	class Demo
	{
		static void Main(string[] args)
		{
			#region Memento pattern
			Console.WriteLine("\nMemento Pattern");
			var editor = new Editor();
			var history = new History();

			editor.Content = "a";
			history.Push(editor.CreateMemento());

			editor.Content = "b";
			history.Push(editor.CreateMemento());

			editor.Content = "c";
			editor.Restore(history.Pop());

			Console.WriteLine($"Final state: {editor.Content}");
			#endregion

			#region State pattern
			Console.WriteLine("\nState Pattern");
			var canvas = new Canvas();
			canvas.CurrentTool = new SelectionTool();
			canvas.MouseDown();
			canvas.MouseUp();
			canvas.CurrentTool = new BrushTool();
			canvas.MouseDown();
			canvas.MouseUp();
			#endregion
		}
	}
}
