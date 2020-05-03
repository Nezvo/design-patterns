using System.Collections.Generic;
using System.Linq;

namespace GangOfFour.Iterator
{
	public class BrowseHistory
	{
		#region Internals and properties
		private readonly List<string> urls = new List<string>(); 
		#endregion

		#region Public methods
		public void Push(string url) => urls.Add(url);

		public string Pop() => urls.Last().Remove(urls.Count);

		public IIterator<string> CreateIterator() => new ListIterator(this);
		#endregion

		#region Helper classes
		/// <summary>
		/// Nested Iterator concrete implementation - encapsulated because it is implementation detail
		/// </summary>
		private class ListIterator : IIterator<string>
		{
			private readonly BrowseHistory history;
			private int index;

			public ListIterator(BrowseHistory history)
			{
				this.history = history;
			}

			public string Current() => history.urls.ElementAt(index);

			public bool HasNext() => index < history.urls.Count;

			public void Next() => index++;
		}
		#endregion
	}
}
