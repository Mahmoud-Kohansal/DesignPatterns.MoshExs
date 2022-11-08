
namespace DesignPatterns.MoshExs.Behavioral.State
{
    internal class DrivingTravel : ITravel
    {
        public void GetDirection()
        {
            Console.WriteLine($"{nameof(DrivingTravel)} Direction...");
        }

        public void GetETA()
        {
            Console.WriteLine($"{nameof(DrivingTravel)} ETA...");
        }
    }
}
