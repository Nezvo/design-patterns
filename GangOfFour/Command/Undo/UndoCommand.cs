using GangOfFour.Command.Interface;

namespace GangOfFour.Command.Undo
{
	class UndoCommand : ICommand
	{
		private readonly History history;

		public UndoCommand(History history)
		{
			this.history = history;
		}

		public void Execute()
		{
			if (history.Count > 0)
				history.Pop().Undo();
		}
	}
}
