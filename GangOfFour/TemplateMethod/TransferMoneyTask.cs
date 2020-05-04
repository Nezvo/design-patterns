using System;

namespace GangOfFour.TemplateMethod
{
	public class TransferMoneyTask : TaskTemplate
	{
		/// <summary>
		/// Concrete tamplate implementation
		/// </summary>
		protected override void DoExecute() => Console.WriteLine("Transfered money");
	}
}
