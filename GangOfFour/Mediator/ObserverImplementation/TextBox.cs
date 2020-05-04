namespace GangOfFour.Mediator.ObserverImplementation
{
	public class TextBox : UIControl
	{
		private string text;

		public string Text
		{
			get
			{
				return text;
			}
			set
			{
				text = value;
				NotifyObservers();
			}
		}
	}
}
