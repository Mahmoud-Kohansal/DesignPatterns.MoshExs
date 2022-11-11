
namespace DesignPatterns.MoshExs.Behavioral.Mediator
{
    public class ListBox : UIControl
    {
        private string _Selection;

        public ListBox(Dialogbox dialogbox):base(dialogbox)
        {
         
        }
        public string Selection { get => _Selection; 
            set { 
                _Selection = value;
                _Owner.Changed(this);
            } }
    }
}
