namespace GangOfFour.Mediator.ObserverImplementation
{
	public class Button : UIControl
	{
		private bool isEnabled;

		public bool IsEnabled
		{
			get
			{
				return isEnabled;
			}
			set
			{
				isEnabled = value;
				NotifyEventHandlers();
			}
		}
	}
}
