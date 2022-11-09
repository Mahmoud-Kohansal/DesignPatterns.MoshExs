
namespace DesignPatterns.MoshExs.Behavioral.Strategy
{
    public class HighContrastFilter : IImageFilter
    {
        public void Apply()
        {
            Console.WriteLine("Applying High-Contrast filter...");
        }
    }
}
