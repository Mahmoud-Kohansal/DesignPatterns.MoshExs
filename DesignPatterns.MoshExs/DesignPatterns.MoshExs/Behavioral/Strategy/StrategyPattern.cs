
namespace DesignPatterns.MoshExs.Behavioral.Strategy
{
    public class StrategyPattern
    {
        public static void Run()
        {
            Console.WriteLine("------------------ Strategy(Image Storage) -----------------");
            ImageStorage imageStorage = new();
            imageStorage.Store("myFile.txt", new PNGCompressor(), new BlackWhiteFilter());
            ChatClient chatClient = new();
            Console.WriteLine("------------------ Strategy(Encrypyion) -----------------");
            chatClient.SendMessage("My Message", new DESEncryption());
        }
        
    }
}
