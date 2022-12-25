
namespace DesignPatterns.MoshExs.Structural.FlyWeight
{
    public class PointIcon
    {
        public readonly PointType Type;
        public readonly string? Icon;
        public PointIcon(PointType type, string? icon)
        {
            Type = type;
            Icon = icon;
        }
    }
    public enum PointType
    {
        CAFE,
        FUEL,
        RESTURANT,
        POLICE
    }
}
