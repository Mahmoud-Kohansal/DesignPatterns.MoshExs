

using DesignPatterns.MoshExs.Behavioral.Command.FX;

namespace DesignPatterns.MoshExs.Behavioral.Command.PhotoshopAction
{
    public class CompositeCommand
    {
        private List<ICommand> _Commands = new();

        public void AddCommand(ICommand cmd)
        {
            _Commands.Add(cmd);
        }
        public void Execute()
        {
            foreach (var cmd in _Commands)
            {
                cmd.Execute();
            }
        }
    }
}
