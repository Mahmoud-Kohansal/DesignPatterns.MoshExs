
namespace DesignPatterns.MoshExs.Structural.FlyWeight
{
    public class PointIconFactory
    {
        Dictionary<PointType, PointIcon> iconMap = new();
        public PointIcon CreatePointIcon(PointType pointType)
        {
            if (!iconMap.ContainsKey(pointType))
            {
                // read icon icon image from system files /icons/pointType.jpg
                PointIcon pointIcon = new(pointType, $"{pointType} icon");
                iconMap.Add(pointType, pointIcon);
            }
            return iconMap[pointType];
        }
    }
}
