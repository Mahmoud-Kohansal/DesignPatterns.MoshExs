

namespace DesignPatterns.MoshExs.Behavioral.Strategy
{
    public class ChatClient
    {
        public void SendMessage(string message, IEncryption encryption)
        {
            string encMessage = encryption.Encrypt(message);
            Console.WriteLine($"Sending {encMessage} ...");
        }
    }
}
