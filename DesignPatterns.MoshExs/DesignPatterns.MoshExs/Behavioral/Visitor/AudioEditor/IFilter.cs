namespace DesignPatterns.MoshExs.Behavioral.Visitor.AudioEditor
{
    public interface IFilter
    {
        void ApplyTo(FormatSegment formatSegment);
        void ApplyTo(FactSegment factSegment);
    }
}
