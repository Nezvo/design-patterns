namespace GangOfFour.Mediator
{
	/// <summary>
	/// Concrete colleague
	/// </summary>
	public class ListBox : UIControl
	{
		private string selection;

		public string Selection
		{
			get
			{
				return selection;
			}
			set
			{
				selection = value;
				owner.Changed(this);
			}
		}

		public ListBox(DialogBox dialogBox) : base(dialogBox) { }
	}
}
