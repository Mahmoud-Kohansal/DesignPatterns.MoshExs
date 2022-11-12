

namespace DesignPatterns.MoshExs.Behavioral.ChainOfResponsibility
{
    public class WebServer
    {
        private readonly Handler _Handler;

        public WebServer(Handler handler)
        {
            _Handler = handler;
        }
        public void Handle(HttpRequest request)
        {
            _Handler.Handle(request);
        }
    }
}
