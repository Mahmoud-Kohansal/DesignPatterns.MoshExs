
namespace DesignPatterns.MoshExs.Behavioral.TemplateMethod
{
    public abstract class Window
    {
        public void Close()
        {
            OnClose();
            Console.WriteLine("Removing window from screen!");
            OnClosed();

        }
        protected abstract void OnClose();
        protected abstract void OnClosed();
    }
}
