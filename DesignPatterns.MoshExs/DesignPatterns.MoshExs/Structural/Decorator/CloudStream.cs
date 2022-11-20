
namespace DesignPatterns.MoshExs.Structural.Decorator
{
    public class CloudStream : IStream
    {
        public void Write(string stream)
        {
            Console.WriteLine($"Write the {stream} on the cloud!");
        }
    }
}
