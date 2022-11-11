
namespace DesignPatterns.MoshExs.Behavioral.Mediator
{
    public class Button: UIControl
    {
        private bool _Enabled;

        public Button(Dialogbox dialogbox):base(dialogbox)
        {
        }
        public bool Enabled { get => _Enabled; set {
                _Enabled = value;
                _Owner.Changed(this);
            } }
    }
}
