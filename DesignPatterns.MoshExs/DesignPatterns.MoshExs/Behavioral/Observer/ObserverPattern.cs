
namespace DesignPatterns.MoshExs.Behavioral.Observer
{
    public class ObserverPattern
    {
        public static void Run()
        {
            DataSource dataSource = new();
            dataSource.AddObserver(new SpreadSheet());
            dataSource.AddObserver(new Chart());
            dataSource.Value = "Hey there!";
        }
    }
}
