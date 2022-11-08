namespace DesignPatterns.MoshExs.Behavioral.Iterator
{
    public static class IteratorPattern
    {
        public static void Run()
        {
            ProductCollection productCollection = new();
            productCollection.Add(new Product(1, "P1"));
            productCollection.Add(new Product(2, "P2"));
            productCollection.Add(new Product(3, "P3"));
            IIteratorProduct iteratorProducts = productCollection.CreateIterator();
            while (iteratorProducts.HasNext())
            {
                var product = iteratorProducts.Current();
                Console.WriteLine(product.ToString());
                iteratorProducts.MoveNext();
            }

        }
    }
}
