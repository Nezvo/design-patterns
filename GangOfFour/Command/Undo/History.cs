using GangOfFour.Command.Interface;
using System.Collections.Generic;

namespace GangOfFour.Command.Undo
{
	public class History
	{
		private readonly Stack<IUndoableCommand> commands = new Stack<IUndoableCommand>();

		public int Count => commands.Count;

		public void Push(IUndoableCommand undoableCommand) => commands.Push(undoableCommand);

		public IUndoableCommand Pop() => commands.Pop();
	}
}
