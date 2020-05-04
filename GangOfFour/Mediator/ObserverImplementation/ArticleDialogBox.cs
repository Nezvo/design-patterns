using System;

namespace GangOfFour.Mediator.ObserverImplementation
{
	public class ArticleDialogBox
	{
		private readonly ListBox articleslistBox;
		private readonly TextBox titleTextBox;
		private readonly Button saveButton;

		public ArticleDialogBox()
		{
			articleslistBox = new ListBox();
			articleslistBox.AddEventHandler(() => ArticleSelected());
			titleTextBox = new TextBox();
			titleTextBox.AddEventHandler(() => TitleChanged());
			saveButton = new Button();
		}

		public void SimulateUserInteraction1()
		{
			articleslistBox.Selection = "Article2";
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
			articleslistBox.Selection = "Manual entry 2";
			Console.WriteLine($"TextBox: {titleTextBox.Text}");
			Console.WriteLine($"Button: {saveButton.IsEnabled}");
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
