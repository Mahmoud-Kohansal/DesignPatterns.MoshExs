
namespace DesignPatterns.MoshExs.Structural.Facade
{
    public class NotificationServer
    {

        public Connection Connect(string ip)
        {
            return new Connection();
        }
        public AuthToken Authenticate(string appId, string key)
        {
            return new AuthToken();
        }
        public void Send(AuthToken authToken, Message message, string target)
        {
            Console.WriteLine($"Sending '{message.Content}'  message...");
        }
    }
}
