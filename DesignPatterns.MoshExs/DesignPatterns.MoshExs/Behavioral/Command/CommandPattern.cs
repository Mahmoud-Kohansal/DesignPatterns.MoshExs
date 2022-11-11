

using DesignPatterns.MoshExs.Behavioral.Command.FX;
using DesignPatterns.MoshExs.Behavioral.Command.PhotoshopAction;

namespace DesignPatterns.MoshExs.Behavioral.Command
{
    public static class CommandPattern
    {
        public static void Run()
        {
            CustomerService customerService = new();
            AddCustomerCommand addCustomerCommand = new(customerService);
            Button btn = new(addCustomerCommand);
            btn.Click();
            Console.WriteLine("------------------- Action Example -----------------");
            CompositeCommand compositeCommand = new();
            compositeCommand.AddCommand(new ResizeCommand());
            compositeCommand.AddCommand(new BWFilterCommand());
            compositeCommand.Execute();
        }
    }
}
