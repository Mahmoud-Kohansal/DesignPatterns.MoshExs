
namespace DesignPatterns.MoshExs.Behavioral.Mediator
{
    public class UIControl
    {
        protected readonly Dialogbox _Owner;

        public UIControl(Dialogbox dialogbox)
        {
            _Owner = dialogbox;
        }

    }
}
