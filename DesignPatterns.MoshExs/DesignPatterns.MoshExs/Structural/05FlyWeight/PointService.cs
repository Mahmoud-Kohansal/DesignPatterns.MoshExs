
namespace DesignPatterns.MoshExs.Structural.FlyWeight
{
    public class PointService
    {
        private List<Point> Points { get; set; } = new();
        public PointService(PointIconFactory pointIconFactory)
        {
            Point cafe = new(10, 20, pointIconFactory.CreatePointIcon(PointType.CAFE));
            Points.Add(cafe);
            Point fuel = new(30, 40, pointIconFactory.CreatePointIcon(PointType.FUEL));
            Points.Add(fuel);
        }
        public List<Point> GetPoints()
        {
            return Points;
        }
    }
}
