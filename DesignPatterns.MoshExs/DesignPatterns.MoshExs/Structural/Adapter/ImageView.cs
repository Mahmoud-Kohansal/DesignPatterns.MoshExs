
namespace DesignPatterns.MoshExs.Structural.Adapter
{
    public class ImageView
    {
        private Image _Image;

        public void ApplyFilter(IImageFilter filter)
        {
            filter.Apply(_Image);
        }
    }
}
