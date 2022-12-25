
namespace DesignPatterns.MoshExs.Structural.FlyWeight
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointIcon? PointIcon { get; set; }
        public Point(int x, int y, PointIcon? pointIcon)
        {
            X = x;
            Y = y;
            PointIcon = pointIcon;
        }
        public void Draw()
        {
            Console.WriteLine($"{PointIcon?.Icon} at ({X}, {Y})");
        }
    }
}
