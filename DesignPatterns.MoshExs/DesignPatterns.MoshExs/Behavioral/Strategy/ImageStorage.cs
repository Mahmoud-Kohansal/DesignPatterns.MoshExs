

namespace DesignPatterns.MoshExs.Behavioral.Strategy
{
    public class ImageStorage
    {        
        public void Store(string fileName, IImageCompression compressor, IImageFilter filter)
        {
            compressor.Compress();
            filter.Apply();
            Console.WriteLine($"Storing {fileName}....");
        }
    }
}
