
namespace DesignPatterns.MoshExs.Behavioral.Iterator
{
    public interface IIteratorProduct
    {
        bool HasNext();
        Product Current();
        void MoveNext();
    }
}
