
namespace DesignPatterns.MoshExs.Behavioral.ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next): base(next)
        {

        }
        protected override bool DoHandle(HttpRequest request)
        {
            bool isValid = request.Username == "admin" && request.Password == "123";
            Console.WriteLine("Authentication");
            return !isValid;
        }
    }
}
