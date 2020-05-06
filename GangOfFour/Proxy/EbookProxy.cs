namespace GangOfFour.Proxy
{
	public class EbookProxy : IEbook
	{
		private RealEbook ebook;
		public string FileName { get; }

		public EbookProxy(string fileName)
		{
			FileName = fileName;
		}

		public void Show()
		{
			// Lazy initialization
			if (ebook == null)
				ebook = new RealEbook(FileName);

			ebook.Show();
		}
	}
}
