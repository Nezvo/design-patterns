namespace GangOfFour.Memento
{
	public class Editor
	{
		public string Content { get; set; }

		public EditorMemento CreateMemento()
		{
			return new EditorMemento(Content);
		}

		public void Restore(EditorMemento state) => Content = state.Content;
	}
}
