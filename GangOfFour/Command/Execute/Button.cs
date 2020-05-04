using GangOfFour.Command.Interface;

namespace GangOfFour.Command
{
	/// <summary>
	/// Invoker
	/// </summary>
	public class Button
	{
		private ICommand command;

		public Button(ICommand command)
		{
			this.command = command;
		}

		public string Label { get; set; }

		public void Click()
		{
			command.Execute();
		}
	}
}
