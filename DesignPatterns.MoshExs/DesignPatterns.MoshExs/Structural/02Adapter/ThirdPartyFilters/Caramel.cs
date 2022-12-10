
namespace DesignPatterns.MoshExs.Structural.Adapter.ThirdPartyFilters
{
    public class Caramel
    {
        public Caramel()
        {

        }
        public void Render(Image image)
        {
            Console.WriteLine("Caramel-ImageFilter applied by Adapter pattern." );
        }
    }
}
