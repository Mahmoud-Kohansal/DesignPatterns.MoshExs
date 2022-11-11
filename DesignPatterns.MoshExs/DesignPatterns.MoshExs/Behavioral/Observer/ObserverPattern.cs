using DesignPatterns.MoshExs.Behavioral.Observer.Pull;

namespace DesignPatterns.MoshExs.Behavioral.Observer
{
    public class ObserverPattern
    {
        public static void Run()
        {
            DataSource dataSource = new();
            dataSource.AddObserver(new SpreadSheet());
            dataSource.AddObserver(new Chart());

            dataSource.AddObserver(new SpreadSheetPull(dataSource));
            dataSource.AddObserver(new ChartPull(dataSource));

            dataSource.Value = "New Value!";

        }
    }
}
