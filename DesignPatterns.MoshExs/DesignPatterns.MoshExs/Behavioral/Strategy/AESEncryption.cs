
namespace DesignPatterns.MoshExs.Behavioral.Strategy
{
    public class AESEncryption : IEncryption
    {
        public string Encrypt(string cypherText)
        {
            return $"AES({cypherText})";
        }
    }
}
