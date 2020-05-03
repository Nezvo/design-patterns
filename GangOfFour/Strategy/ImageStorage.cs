namespace GangOfFour.Strategy
{
	/// <summary>
	/// Context
	/// </summary>
	public class ImageStorage
	{
		public ICompressor Compressor { get; set; }
		public IFilter Filter { get; set; }

		public void Store(string fileName)
		{
			Filter.Apply(fileName);
			Compressor.Compress(fileName);
		}
	}
}
