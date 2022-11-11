
namespace DesignPatterns.MoshExs.Behavioral.Observer.Pull
{
    public class ChartPull : IObserver
    {
        private readonly DataSource dataSource;

        public ChartPull(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("Update Chart: " + dataSource.Value);
        }
    }
}
