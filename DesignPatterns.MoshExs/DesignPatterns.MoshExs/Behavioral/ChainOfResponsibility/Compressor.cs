
namespace DesignPatterns.MoshExs.Behavioral.ChainOfResponsibility
{
    public class Compressor : Handler
    {
        public Compressor()
        {

        }
        public Compressor(Handler next) : base(next)
        {

        }
        protected override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Compress");
            return true;
        }
    }
}
