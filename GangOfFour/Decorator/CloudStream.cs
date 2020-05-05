using System;

namespace GangOfFour.Decorator
{
	/// <summary>
	/// Concrete component
	/// </summary>
	public class CloudStream : IStream
	{
		public virtual void Write(string data) => Console.WriteLine($"Storing {data}");
	}
}
