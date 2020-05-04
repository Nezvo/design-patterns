using GangOfFour.Command.Interface;

namespace GangOfFour.Command.Undo
{
	class BoldCommand : IUndoableCommand
	{
		private string prevContent;
		private readonly Document document;
		private readonly History history;

		public BoldCommand(Document document, History history)
		{
			this.document = document;
			this.history = history;
		}

		public void Execute()
		{
			prevContent = document.Content;
			document.Content = "<b>" + document.Content + "</b>";
			history.Push((BoldCommand)this.MemberwiseClone());
		}

		public void Undo()
		{
			document.Content = prevContent;
		}
	}
}
