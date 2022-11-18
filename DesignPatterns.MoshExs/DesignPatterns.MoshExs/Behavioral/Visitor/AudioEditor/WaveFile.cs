
namespace DesignPatterns.MoshExs.Behavioral.Visitor.AudioEditor
{
    public class WaveFile
    {
        List<ISegment> _Segments = new();
        public void AddSegment(ISegment segment)
        {
            _Segments.Add(segment);
        }
        public void ApplyFilter(IFilter filter)
        {
            foreach (var segment in _Segments)
            {
                segment.Apply(filter);
            }
        }
    }
}
