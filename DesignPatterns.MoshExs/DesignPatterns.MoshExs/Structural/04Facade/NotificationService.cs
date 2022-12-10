
namespace DesignPatterns.MoshExs.Structural.Facade
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            NotificationServer notificationServer = new();
            Connection conn = notificationServer.Connect(ip: "ip");
            AuthToken token = notificationServer.Authenticate(appId: "123", key: "key");
            notificationServer.Send(token, new Message(message), target);
            conn.Disconnect();
        }
    }
}
