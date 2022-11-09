
namespace DesignPatterns.MoshExs.Behavioral.Strategy
{
    public class JPGCompressor : IImageCompression
    {
        public void Compress()
        {
            Console.WriteLine("Compress JPG...");
        }
    }
}
