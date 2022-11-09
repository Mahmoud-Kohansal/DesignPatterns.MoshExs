

namespace DesignPatterns.MoshExs.Behavioral.Strategy
{
    public class BlackWhiteFilter : IImageFilter
    {
        public void Apply()
        {
            Console.WriteLine("Applying B&W filter....");
        }
    }
}
