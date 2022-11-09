
namespace DesignPatterns.MoshExs.Behavioral.Strategy
{
    public class PNGCompressor : IImageCompression
    {
        public void Compress()
        {
            Console.WriteLine("Compress PNG...");
        }
    }
}
