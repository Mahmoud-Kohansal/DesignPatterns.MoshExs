
namespace DesignPatterns.MoshExs.Behavioral.Strategy
{
    public class StrategyPattern
    {
        public static void Run()
        {
            ImageStorage imageStorage = new();
            imageStorage.Store("myFile.txt", new PNGCompressor(), new BlackWhiteFilter());
        }
        
    }
}
