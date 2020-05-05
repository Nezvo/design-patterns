using System.Linq;

namespace GangOfFour.Decorator
{
	/// <summary>
	/// Decorator
	/// </summary>
	public class CompressedCloudStream : IStream
	{
		private readonly IStream stream;

		public CompressedCloudStream(IStream stream)
		{
			this.stream = stream;
		}

		public void Write(string data)
		{
			var compressedData = Compress(data);
			stream.Write(compressedData);
		}

		private string Compress(string data) => data.Substring(0, 5);
	}
}
