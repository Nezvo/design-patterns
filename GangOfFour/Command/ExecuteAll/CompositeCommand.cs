using GangOfFour.Command.Interface;
using System.Collections.Generic;

namespace GangOfFour.Command
{
	public class CompositeCommand : ICommand
	{
		private readonly List<ICommand> commands = new List<ICommand>();

		public void Add(ICommand command) => commands.Add(command);

		public void Execute() => commands.ForEach(command => command.Execute());
	}
}
