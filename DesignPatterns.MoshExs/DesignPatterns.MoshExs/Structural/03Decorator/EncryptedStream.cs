
namespace DesignPatterns.MoshExs.Structural.Decorator
{
    public class EncryptedStream : IStream
    {
        private readonly IStream _Stream;

        public EncryptedStream(IStream stream)
        {
            _Stream = stream;
        }
        public void Write(string stream)
        {
            Console.WriteLine("Encypting...");
            string enc = Encrypt(stream);
            _Stream.Write(enc);
        }
        private string Encrypt(string data)
        {
            return $"Encrypted {data} is #$@()_NLKJLK*()*^&&*%^";
        }
    }
}
