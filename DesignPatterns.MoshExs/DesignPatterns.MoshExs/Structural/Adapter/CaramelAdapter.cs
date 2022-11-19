
using DesignPatterns.MoshExs.Structural.Adapter.ThirdPartyFilters;

namespace DesignPatterns.MoshExs.Structural.Adapter
{
    public class CaramelAdapter : IImageFilter
    {
        private Caramel _Caramel;
        public CaramelAdapter(Caramel caramel)
        {
            _Caramel = caramel;
        }
        public void Apply(Image image)
        {
            _Caramel.Render(image);
        }
    }
}
