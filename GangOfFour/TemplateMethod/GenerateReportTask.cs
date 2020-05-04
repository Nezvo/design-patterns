using System;

namespace GangOfFour.TemplateMethod
{
	/// <summary>
	/// Concrete tamplate implementation
	/// </summary>
	public class GenerateReportTask : TaskTemplate
	{
		protected override void DoExecute() => Console.WriteLine("Generated report");
	}
}
