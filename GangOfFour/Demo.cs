using GangOfFour.Command;
using GangOfFour.Command.Undo;
using GangOfFour.Iterator;
using GangOfFour.Memento;
using GangOfFour.State;
using GangOfFour.Strategy;
using GangOfFour.TemplateMethod;
using System;

namespace GangOfFour
{
	class Demo
	{
		static void Main()
		{
			#region Memento pattern
			Console.WriteLine("\nMemento Pattern demo:");
			var editor = new Editor();
			var history = new Memento.History();

			editor.Content = "a";
			history.Push(editor.CreateMemento());

			editor.Content = "b";
			history.Push(editor.CreateMemento());

			editor.Content = "c";
			editor.Restore(history.Pop());

			Console.WriteLine($"Final state: {editor.Content}");
			#endregion

			#region State pattern
			Console.WriteLine("\nState Pattern demo:");
			var canvas = new Canvas();
			canvas.CurrentTool = new SelectionTool();
			canvas.MouseDown();
			canvas.MouseUp();
			canvas.CurrentTool = new BrushTool();
			canvas.MouseDown();
			canvas.MouseUp();
			#endregion

			#region Iterator pattern
			Console.WriteLine("\nIterator Pattern demo:");
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
			Console.WriteLine("\nStrategy Pattern demo:");
			var imageStorage = new ImageStorage();
			imageStorage.Compressor = new JpegCompressor();
			imageStorage.Filter = new BlackAndWhiteFilter();
			imageStorage.Store("image");
			imageStorage.Compressor = new PngCompressor();
			imageStorage.Store("image");
			#endregion

			#region Template mehod pattern
			Console.WriteLine("\nTemplate Method Pattern demo:");
			var transferMoneyTask = new TransferMoneyTask();
			var generateReportTask = new GenerateReportTask();
			transferMoneyTask.Execute();
			generateReportTask.Execute();
			#endregion

			#region Command pattern
			Console.WriteLine("\nCommand Pattern demo:");
			var service = new CustomerService();
			var command = new AddCustomerCommand(service);
			var button = new Button(command);
			button.Click();

			// Used for recording user commands and replaying them or undoing them
			var composite = new CompositeCommand();
			composite.Add(new ResizeCommand());
			composite.Add(new BlackAndWhiteCommand());
			composite.Execute();
			composite.Execute();

			// Track changes and ability to undo them
			var historyCommand = new Command.Undo.History();
			var document = new Document();
			document.Content = "Content";
			var boldCommand = new BoldCommand(document, historyCommand);
			var undoCommand = new UndoCommand(historyCommand);
			boldCommand.Execute();
			boldCommand.Execute();
			Console.WriteLine(document.Content);
			undoCommand.Execute();
			Console.WriteLine(document.Content);
			undoCommand.Execute();
			Console.WriteLine(document.Content);

			#endregion
		}
	}
}
