
namespace DesignPatterns.MoshExs.Behavioral.Mediator
{
    public class TextBox : UIControl
    {
        private string _Content;

        public TextBox(Dialogbox dialogbox):base(dialogbox)
        {
         
        }
        public string Content { get => _Content; 
            set { 
                _Content = value;
                _Owner.Changed(this);
            } }
    }
}
