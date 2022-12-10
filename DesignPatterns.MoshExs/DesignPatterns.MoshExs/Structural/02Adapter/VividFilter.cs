
namespace DesignPatterns.MoshExs.Structural.Adapter
{
    public class VividFilter : IImageFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Vivid-ImageFilter");
        }
    }
}
