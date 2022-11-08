
namespace DesignPatterns.MoshExs.Behavioral.State
{
    public static class StatePattern
    {
        public static void Run()
        {
            Console.WriteLine("---------- Driving ----------------");
            var directionService = new DirectionService(new DrivingTravel());
            directionService.GetETA();
            directionService.GetDirection();
            Console.WriteLine("---------- Bicycle ----------------");
            directionService.SetTravel(new BicyclingTravel());
            directionService.GetETA();
            directionService.GetDirection();
        }
    }
}
