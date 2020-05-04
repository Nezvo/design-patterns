namespace GangOfFour.Command.Interface
{
	public interface IUndoableCommand : ICommand
	{
		void Undo();
	}
}
