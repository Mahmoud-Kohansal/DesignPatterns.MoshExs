
namespace DesignPatterns.MoshExs.Behavioral.Strategy
{
    public class DESEncryption : IEncryption
    {
        public string Encrypt(string cypherText)
        {
            return $"DES({cypherText})";
        }
    }
}
