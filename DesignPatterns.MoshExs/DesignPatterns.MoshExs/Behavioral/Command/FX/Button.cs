
namespace DesignPatterns.MoshExs.Behavioral.Command.FX
{
    public class Button
    {
        private string _Label;
        private readonly ICommand _Command;

        public string Label { get => _Label; set => _Label = value; }

        public Button(ICommand command)
        {
            _Command = command;
        }
        public void Click()
        {
            _Command.Execute();
        }


    }
}
