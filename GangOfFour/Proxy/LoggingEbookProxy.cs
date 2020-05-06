using System;

namespace GangOfFour.Proxy
{
	class LoggingEbookProxy : IEbook
	{
		private RealEbook ebook;
		public string FileName { get; }

		public LoggingEbookProxy(string fileName)
		{
			FileName = fileName;
		}

		public void Show()
		{
			// Lazy initialization
			if (ebook == null)
				ebook = new RealEbook(FileName);

			Console.WriteLine("Logging");
			ebook.Show();
		}
	}
}
