using GangOfFour.Command.Interface;
using System;

namespace GangOfFour.Command
{
	public class BlackAndWhiteCommand : ICommand
	{
		public void Execute() => Console.WriteLine("Applied B&W filter");
	}
}
