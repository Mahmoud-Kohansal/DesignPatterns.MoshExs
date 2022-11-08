
namespace DesignPatterns.MoshExs.Behavioral.State
{
    public class BicyclingTravel : ITravel
    {
        public void GetDirection()
        {
            Console.WriteLine($"{nameof(BicyclingTravel)} Direction...");
        }

        public void GetETA()
        {
            Console.WriteLine($"{nameof(BicyclingTravel)} ETA");
        }
    }
}
