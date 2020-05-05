using System;

namespace GangOfFour.ChainOfResponsibility
{
	public class Authenticator : Handler
	{
		public Authenticator(Handler next) : base(next) { }

		public override bool DoHandle(HttpRequest request)
		{
			var isValid = request.Username == "user" && request.Password == "pass";
			Console.WriteLine($"Authentication {(isValid ? "successful" : "failed")}");

			return isValid;
		}
	}
}
