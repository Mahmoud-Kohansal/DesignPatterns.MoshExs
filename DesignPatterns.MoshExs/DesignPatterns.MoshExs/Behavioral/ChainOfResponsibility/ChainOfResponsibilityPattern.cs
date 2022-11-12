
namespace DesignPatterns.MoshExs.Behavioral.ChainOfResponsibility
{
    public static class ChainOfResponsibilityPattern
    {
        public static void Run()
        {
            // Authenticate -> Logger -> Compress
            Compressor compressor = new();
            Logger logger = new(compressor);
            Authenticator authenticator = new(logger);
            WebServer webServer = new(authenticator);
            webServer.Handle(new HttpRequest(username: "admin", password: "123"));

        }
    }
}
