namespace GangOfFour.Strategy
{
	/// <summary>
	/// Strategy
	/// </summary>
	public interface ICompressor
	{
		// byte[] Compress(byte[] image);
		void Compress(string fileName);
	}
}
