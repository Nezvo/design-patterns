using System.Collections.Generic;

namespace GangOfFour.Proxy
{
	public class Library
	{
		private readonly Dictionary<string, IEbook> ebooks = new Dictionary<string, IEbook>();

		public void Add(IEbook ebook) => ebooks.Add(ebook.FileName, ebook);

		public void Open(string fileName) => ebooks[fileName]?.Show();
	}
}
