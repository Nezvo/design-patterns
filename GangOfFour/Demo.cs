using GangOfFour.Adapter;
using GangOfFour.Adapter.ExternalFilters;
using GangOfFour.Bridge;
using GangOfFour.ChainOfResponsibility;
using GangOfFour.Command;
using GangOfFour.Command.Undo;
using GangOfFour.Composite;
using GangOfFour.Decorator;
using GangOfFour.Facade;
using GangOfFour.Flyweight;
using GangOfFour.Iterator;
using GangOfFour.Mediator;
using GangOfFour.Memento;
using GangOfFour.Observer;
using GangOfFour.State;
using GangOfFour.Strategy;
using GangOfFour.TemplateMethod;
using GangOfFour.Visitor;
using System;

namespace GangOfFour
{
	class Demo
	{
		static void Main()
		{
			#region Behavioural patterns

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

			#region Template method pattern
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
			var button = new Command.Button(command);
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

			#region Observer pattern
			// Microsoft already provided the IObserver<T> and IObservable<T> interfaces provide a generalized mechanism for the observer design pattern.
			// The IObservable<T> interface represents the class that sends notifications (the provider/source)
			// The IObserver<T> interface represents the class that receives them (the observer).
			Console.WriteLine("\nObserver Pattern demo:");
			var dataSource = new DataSource();
			var sheet1 = new Spreadsheet(dataSource);
			var sheet2 = new Spreadsheet(dataSource);
			var chart = new Chart(dataSource);
			dataSource.AddObserver(sheet1);
			dataSource.AddObserver(sheet2);
			dataSource.AddObserver(chart);
			dataSource.Value = 3;
			dataSource.Value = 2;
			#endregion

			#region Mediator pattern
			Console.WriteLine("\nMediator Pattern demo:");
			var article = new ArticleDialogBox();
			article.SimulateUserInteraction1();
			article.SimulateUserInteraction2();
			article.SimulateUserInteraction3();

			Console.WriteLine("\nMediator Pattern using observer pattern demo:");
			var article2 = new Mediator.ObserverImplementation.ArticleDialogBox();
			article2.SimulateUserInteraction1();
			article2.SimulateUserInteraction2();
			article2.SimulateUserInteraction3();
			#endregion

			#region Chain of responsibility pattern
			Console.WriteLine("\nChain of Responsibility Pattern demo:");
			// We create chain authenticator -> logger -> compressor -> encryptor
			var encryptor = new Encryptor(null);
			var compressor = new Compressor(encryptor);
			var logger = new Logger(compressor);
			var authenticator = new Authenticator(logger);
			// We pass our first handler from the chain
			var server = new WebServer(authenticator);
			Console.WriteLine("Correct username & password:");
			server.Handle(new HttpRequest("user", "pass"));
			Console.WriteLine("Incorrect username & password:");
			server.Handle(new HttpRequest("user", "1234"));
			#endregion

			#region Visitor pattern
			Console.WriteLine("\nVisitor Pattern demo:");
			var htmlDocument = new HtmlDocument();
			htmlDocument.AddNode(new HeadingNode());
			htmlDocument.AddNode(new AnchorNode());
			htmlDocument.Execute(new HighlightVisitor());
			htmlDocument.Execute(new PlainTextVisitor());
			#endregion

			#endregion

			#region Structural patterns

			#region Composite pattern
			Console.WriteLine("\nComposite Pattern demo:");
			var group1 = new Group();
			group1.Add(new Shape());
			group1.Add(new Shape());
			var group2 = new Group();
			group2.Add(new Shape());
			group2.Add(new Shape());

			var group = new Group();
			group.Add(group1);
			group.Add(group2);
			group.Render();
			group.Move();
			#endregion

			#region Adapter pattern
			Console.WriteLine("\nAdapter Pattern demo:");
			var image = new ImageView(new Image());
			image.Apply(new CaramelFilterAdapterUsingComposition(new CaramelFilter()));
			image.Apply(new CaramelFilterAdapterUsingInheritance());
			#endregion

			#region Decorator pattern
			Console.WriteLine("\nDecorator Pattern demo:");
			// We decorate CloudStream with CompressedCloudStream and then EncryptedCloudStream
			// first encrypting then compressing the data
			var cloudStream = new EncryptedCloudStream(new CompressedCloudStream(new CloudStream()));
			cloudStream.Write("Test data");
			#endregion

			#region Facade pattern
			Console.WriteLine("\nFacade Pattern demo:");
			var notificationService = new NotificationService();
			notificationService.Send("message", "target");
			#endregion

			#region Flyweight pattern
			Console.WriteLine("\nFlyweight Pattern demo:");
			var pointService = new PointService(new PointIconFactory());
			foreach (var point in pointService.GetPoints())
			{
				point.Draw();
			}
			#endregion

			#region Bridge pattern
			Console.WriteLine("\nBridge Pattern demo:");
			var remoteControl = new AdvancedRemoteControl(new SamsungTV());
			remoteControl.TurnOn();
			remoteControl.SetChannel(1);
			#endregion

			#endregion
		}
	}
}
