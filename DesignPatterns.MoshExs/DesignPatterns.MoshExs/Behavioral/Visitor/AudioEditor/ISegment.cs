
namespace DesignPatterns.MoshExs.Behavioral.Visitor.AudioEditor
{
    public interface ISegment
    {
        public void Apply(IFilter filter);
    }
}
