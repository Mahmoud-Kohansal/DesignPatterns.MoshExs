
namespace DesignPatterns.MoshExs.Behavioral.Iterator
{
    public class ProductCollection
    {
        private List<Product> _Products = new();

        public void Add(Product product)
        {
            _Products.Add(product);
        }

        public IIteratorProduct CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : IIteratorProduct
        {
            private readonly ProductCollection _ProductCollection;
            private int _Index;
            public ListIterator(ProductCollection productCollection)
            {
                _ProductCollection = productCollection;
            }

            public Product Current() => _ProductCollection._Products[_Index];

            public bool HasNext()
            {
                return (_Index < _ProductCollection._Products.Count);
            }

            public void MoveNext()
            {
                _Index++;
            }
        }

    }
}
