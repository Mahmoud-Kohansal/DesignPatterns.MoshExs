
namespace DesignPatterns.MoshExs.Structural.Adapter
{
    public static class AdapterPattern
    {
        public static void Run()
        {
            ImageView imageView = new();
            imageView.ApplyFilter(new VividFilter());

            imageView.ApplyFilter(new CaramelAdapter(new ThirdPartyFilters.Caramel()));

            Console.WriteLine("-------------- Adapt by iheritance -----------------");
            imageView.ApplyFilter(new CaramelAdapter2());
        }
    }
}
