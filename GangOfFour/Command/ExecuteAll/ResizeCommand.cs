using GangOfFour.Command.Interface;
using System;

namespace GangOfFour.Command
{
	public class ResizeCommand : ICommand
	{
		public void Execute() => Console.WriteLine("Resized");
	}
}
