using System;

namespace GangOfFour.Facade
{
	public class NotificationServer
	{
		public Connection Connect(string ipAddress) => new Connection();

		public AuthToken Authenticate(string appId, string key) => new AuthToken();

		public void Send(AuthToken token, string message, string target) => Console.WriteLine("Sending a message");
	}
}
