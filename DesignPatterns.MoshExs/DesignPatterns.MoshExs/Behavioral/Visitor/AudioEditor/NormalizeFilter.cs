
namespace DesignPatterns.MoshExs.Behavioral.Visitor.AudioEditor
{
    public class NormalizeFilter : IFilter
    {
        public void ApplyTo(FormatSegment formatSegment)
        {
            Console.WriteLine("Normalize-Format Segment");
        }

        public void ApplyTo(FactSegment factSegment)
        {
            Console.WriteLine("Normalize-Fact Segment");
        }
    }
}
