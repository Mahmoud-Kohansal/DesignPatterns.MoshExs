
namespace DesignPatterns.MoshExs.Behavioral.Iterator
{
    public class Product
    {
        private int _Id;
        private string _Name;

        public Product(int id, string name)
        {
            _Id = id;
            _Name = name;
        }
        public override string ToString()
        {
            return $"Product{{id={_Id}, name={_Name}}}";
        }
    }
}