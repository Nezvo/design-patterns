using GangOfFour.Iterator;
using GangOfFour.Memento;
using GangOfFour.State;
using GangOfFour.Strategy;
using System;

namespace GangOfFour
{
	class Demo
	{
		static void Main()
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

			#region Iterator pattern
			Console.WriteLine("\nIterator Pattern");
			var browseHistory = new BrowseHistory();
			browseHistory.Push("a");
			browseHistory.Push("b");
			browseHistory.Push("c");

			var iterator = browseHistory.CreateIterator();
			while (iterator.HasNext())
			{
				Console.WriteLine(iterator.Current());
				iterator.Next();
			}
			#endregion

			#region Strategy pattern
			Console.WriteLine("\nStrategy Pattern");
			var imageStorage = new ImageStorage();
			imageStorage.Compressor = new JpegCompressor();
			imageStorage.Filter = new BlackAndWhiteFilter();
			imageStorage.Store("image");
			imageStorage.Compressor = new PngCompressor();
			imageStorage.Store("image");
			#endregion
		}
	}
}
