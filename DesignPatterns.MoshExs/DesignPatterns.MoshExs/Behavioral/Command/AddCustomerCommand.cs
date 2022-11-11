

using DesignPatterns.MoshExs.Behavioral.Command.FX;

namespace DesignPatterns.MoshExs.Behavioral.Command
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomerService _CustomerService;

        public AddCustomerCommand(CustomerService customerService)
        {
            _CustomerService = customerService;
        }
        public void Execute()
        {
            _CustomerService.AddCustomer();
        }
    }
}
