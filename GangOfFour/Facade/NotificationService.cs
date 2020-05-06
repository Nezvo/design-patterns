namespace GangOfFour.Facade
{
	/// <summary>
	/// Facade
	/// </summary>
	public class NotificationService
	{
		public void Send(string message, string target)
		{
			var notificationServer = new NotificationServer();
			var connection = notificationServer.Connect("ip");
			var authToken = notificationServer.Authenticate("appId", "key");
			notificationServer.Send(authToken, message, target);
			connection.Disconnect();
		}

	}
}
