using System;

namespace GangOfFour.Strategy
{
	/// <summary>
	/// Concrete strategy
	/// </summary>
	public class PnggCompressor : ICompressor
	{
		public void Compress(string fileName) => Console.WriteLine("Compressing using PNG");
	}
}
