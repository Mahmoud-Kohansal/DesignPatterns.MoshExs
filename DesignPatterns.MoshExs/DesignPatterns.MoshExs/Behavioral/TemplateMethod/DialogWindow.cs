
namespace DesignPatterns.MoshExs.Behavioral.TemplateMethod
{
    public class DialogWindow : Window
    {
        protected override void OnClose()
        {
            Console.WriteLine("DialogWindow is closing!");
        }

        protected override void OnClosed()
        {
            Console.WriteLine("Bye dialog!");
        }
    }
}
