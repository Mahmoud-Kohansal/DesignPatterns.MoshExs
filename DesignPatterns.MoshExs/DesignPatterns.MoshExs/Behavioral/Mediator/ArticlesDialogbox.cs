

namespace DesignPatterns.MoshExs.Behavioral.Mediator
{
    public class ArticlesDialogbox : Dialogbox
    {
        private Button _Button;
        private TextBox _TextBox;
        private ListBox _ListBox;
        public ArticlesDialogbox()
        {
            _Button = new(this);
            _TextBox = new(this);
            _ListBox = new(this);
        }

        internal void SimulateUIInteraction()
        {
            _ListBox.Selection = "Article 1";
            _TextBox.Content = "";
            Console.WriteLine("TextBox: " + _TextBox.Content);
            Console.WriteLine("Button: " + _Button.Enabled);
        }

        public override void Changed(UIControl control)
        {
            if (control == _ListBox)
                ListBoxChanged();
            else if (control == _TextBox)
                TextBoxChanged();
        }

        private void TextBoxChanged()
        {
            _Button.Enabled = !string.IsNullOrEmpty(_TextBox.Content);
        }

        private void ListBoxChanged()
        {
            _TextBox.Content = _ListBox.Selection;
            _Button.Enabled = true;
        }
    }
}
