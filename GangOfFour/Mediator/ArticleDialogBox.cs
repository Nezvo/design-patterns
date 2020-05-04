using System;

namespace GangOfFour.Mediator
{
	/// <summary>
	/// Concrete mediator
	/// All logic in one place
	/// </summary>
	public class ArticleDialogBox : DialogBox
	{
		private readonly ListBox articleslistBox;
		private readonly TextBox titleTextBox;
		private readonly Button saveButton;

		public ArticleDialogBox()
		{
			articleslistBox = new ListBox(this);
			titleTextBox = new TextBox(this);
			saveButton = new Button(this);
		}

		public void SimulateUserInteraction1()
		{
			articleslistBox.Selection = "Article1";
			Console.WriteLine($"ListBox selected: {articleslistBox.Selection}");
			Console.WriteLine($"TextBox: {titleTextBox.Text}");
			Console.WriteLine($"Button: {saveButton.IsEnabled}");
		}
		public void SimulateUserInteraction2()
		{
			articleslistBox.Selection = null;
			Console.WriteLine($"ListBox selected: {articleslistBox.Selection ?? "None"}");
			Console.WriteLine($"TextBox: {titleTextBox.Text}");
			Console.WriteLine($"Button: {saveButton.IsEnabled}");
		}

		public void SimulateUserInteraction3()
		{
			articleslistBox.Selection = "Manual entry";
			Console.WriteLine($"TextBox: {titleTextBox.Text}");
			Console.WriteLine($"Button: {saveButton.IsEnabled}");
		}

		/// <summary>
		/// Defines interactions between object
		/// </summary>
		/// <param name="control"></param>
		public override void Changed(UIControl control)
		{
			if (control == articleslistBox)
				ArticleSelected();
			else if (control == titleTextBox)
				TitleChanged();
		}

		private void ArticleSelected()
		{
			titleTextBox.Text = articleslistBox.Selection;
			saveButton.IsEnabled = TitleTextBoxSet();
		}

		private void TitleChanged() => saveButton.IsEnabled = TitleTextBoxSet();

		private bool TitleTextBoxSet() => !string.IsNullOrEmpty(titleTextBox.Text);
	}
}
