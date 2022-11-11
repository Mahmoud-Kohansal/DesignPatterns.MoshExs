
namespace DesignPatterns.MoshExs.Behavioral.Observer.Pull
{
    public class SpreadSheetPull : IObserver
    {
        private readonly DataSource dataSource;

        public SpreadSheetPull(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("Update spreadsheet : "+ dataSource.Value);
        }
    }
}
