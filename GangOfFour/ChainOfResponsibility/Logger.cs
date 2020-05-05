using System;

namespace GangOfFour.ChainOfResponsibility
{
	public class Logger : Handler
	{
		public Logger(Handler next) : base(next) { }

		public override bool DoHandle(HttpRequest request)
		{
			Console.WriteLine("Log");

			return true;
		}
	}
}
