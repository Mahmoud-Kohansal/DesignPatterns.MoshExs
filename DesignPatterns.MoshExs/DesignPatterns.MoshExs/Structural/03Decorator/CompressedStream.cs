
namespace DesignPatterns.MoshExs.Structural.Decorator
{
    public class CompressedStream : IStream
    {
        private readonly IStream _Stream;

        public CompressedStream(IStream stream)
        {
            _Stream = stream;
        }
        public void Write(string stream)
        {
            Console.WriteLine("Compressing...");
            int len = stream.Length < 5 ? stream.Length : 5; 
            _Stream.Write(stream[0.. len]);
        }        
    }
}
