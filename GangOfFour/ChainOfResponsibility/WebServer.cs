namespace GangOfFour.ChainOfResponsibility
{
	public class WebServer
	{
		private readonly Handler handler;

		public WebServer(Handler handler)
		{
			this.handler = handler;
		}

		public void Handle(HttpRequest request) => handler.Handle(request);
	}
}
