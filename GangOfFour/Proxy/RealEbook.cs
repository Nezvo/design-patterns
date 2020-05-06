namespace GangOfFour.Proxy
{
	public class RealEbook : IEbook
	{
		public string FileName { get; }

		public RealEbook(string fileName)
		{
			FileName = fileName;
			Load();
		}

		public void Load() => System.Console.WriteLine($"Loading the eBook {FileName}");

		public void Show() => System.Console.WriteLine($"Showing the eBook {FileName}");
	}
}
