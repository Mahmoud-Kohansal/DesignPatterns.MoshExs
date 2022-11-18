
namespace DesignPatterns.MoshExs.Behavioral.Visitor.AudioEditor
{
    public class FormatSegment : ISegment
    {
        public void Apply(IFilter filter)
        {
            filter.ApplyTo(this);
        }
    }
}
