using System;
using System.Collections.Generic;
using System.Text;

namespace GangOfFour.Strategy
{
	/// <summary>
	/// Strategy
	/// </summary>
	public interface IFilter
	{
		void Apply(string fileName);
	}
}
