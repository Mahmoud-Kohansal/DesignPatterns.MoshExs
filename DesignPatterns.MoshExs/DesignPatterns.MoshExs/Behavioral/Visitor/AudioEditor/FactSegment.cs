

namespace DesignPatterns.MoshExs.Behavioral.Visitor.AudioEditor
{
    public class FactSegment : ISegment
    {
        public void Apply(IFilter filter)
        {
            filter.ApplyTo(this);
        }
    }
}
