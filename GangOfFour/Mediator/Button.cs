namespace GangOfFour.Mediator
{
	/// <summary>
	/// Concrete colleague
	/// </summary>
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
				owner.Changed(this);
			}
		}

		public Button(DialogBox dialogBox) : base(dialogBox) { }
	}
}
