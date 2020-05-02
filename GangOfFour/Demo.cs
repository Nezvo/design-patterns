using GangOfFour.Memento;
using System;

namespace GangOfFour
{
	class Demo
	{
		static void Main(string[] args)
		{
			#region Memento pattern
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
		}
	}
}
