using System.Collections.Generic;

namespace GangOfFour.Memento
{
	public class History
	{
		private readonly Stack<EditorMemento> states = new Stack<EditorMemento>();

		public void Push(EditorMemento state) => states.Push(state);

		public EditorMemento Pop() => states.Pop();
	}
}
