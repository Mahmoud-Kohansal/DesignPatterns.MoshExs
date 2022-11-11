

using DesignPatterns.MoshExs.Behavioral.Command.FX;

namespace DesignPatterns.MoshExs.Behavioral.Command.PhotoshopAction
{
    public class BWFilterCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Black and white filter....");
        }
    }
}
