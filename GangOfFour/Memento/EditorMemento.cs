namespace GangOfFour.Memento
{
	/// <summary>
	/// Memento
	/// </summary>
	public class EditorMemento
	{
		public string Content { get; }

		public EditorMemento(string content)
		{
			Content = content;
		}
	}
}
