
namespace DesignPatterns.MoshExs.Behavioral.Observer
{
    public class Chart : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Update Chart...");
        }
    }
}
