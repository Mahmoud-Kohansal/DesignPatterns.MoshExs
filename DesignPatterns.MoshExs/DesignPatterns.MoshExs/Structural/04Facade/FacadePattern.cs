
namespace DesignPatterns.MoshExs.Structural.Facade
{
    public static class FacadePattern
    {
        public static void Run()
        {
            NotificationService notificationService = new();
            notificationService.Send("My Message", "Beloved");
        }

    }
}
