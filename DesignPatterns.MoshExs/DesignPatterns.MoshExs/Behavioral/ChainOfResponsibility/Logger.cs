
namespace DesignPatterns.MoshExs.Behavioral.ChainOfResponsibility
{
    public class Logger: Handler
    {
        public Logger(Handler handler): base(handler)
        {

        }
        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Log");
            return false;
        }
    }
}
