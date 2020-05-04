using GangOfFour.Command.Interface;

namespace GangOfFour.Command
{
	public class AddCustomerCommand : ICommand
	{
		private CustomerService customerService;

		public AddCustomerCommand(CustomerService customerService)
		{
			this.customerService = customerService;
		}

		public void Execute() => customerService.AddCustomer();
	}
}
