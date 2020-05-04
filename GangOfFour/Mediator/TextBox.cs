namespace GangOfFour.Mediator
{
	/// <summary>
	/// Concrete colleague
	/// </summary>
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
				owner.Changed(this);
			}
		}

		public TextBox(DialogBox dialogBox) : base(dialogBox) { }
	}
}
