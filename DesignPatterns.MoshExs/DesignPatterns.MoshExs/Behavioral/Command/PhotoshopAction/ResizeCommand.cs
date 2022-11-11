
using DesignPatterns.MoshExs.Behavioral.Command.FX;

namespace DesignPatterns.MoshExs.Behavioral.Command.PhotoshopAction
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resizing....");
        }
    }
}
