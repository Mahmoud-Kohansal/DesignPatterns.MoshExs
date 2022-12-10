
using DesignPatterns.MoshExs.Structural.Adapter.ThirdPartyFilters;

namespace DesignPatterns.MoshExs.Structural.Adapter
{
    public class CaramelAdapter2 : Caramel, IImageFilter
    {        
        public void Apply(Image image)
        {
            Render(image);
        }
    }
}
