namespace GangOfFour.Mediator
{
	/// <summary>
	/// Colleague
	/// </summary>
	public class UIControl
	{
		protected DialogBox owner;

		public UIControl(DialogBox owner)
		{
			this.owner = owner;
		}
	}
}
