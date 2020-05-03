using System;

namespace GangOfFour.Strategy
{
	/// <summary>
	/// Concrete strategy
	/// </summary>
	public class BlackAndWhiteFilter : IFilter
	{
		public void Apply(string fileName) => Console.WriteLine("Applying B&W filter");
	}
}
