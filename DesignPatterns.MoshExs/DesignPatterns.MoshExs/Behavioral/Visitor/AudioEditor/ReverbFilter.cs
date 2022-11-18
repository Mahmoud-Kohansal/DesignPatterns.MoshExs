
namespace DesignPatterns.MoshExs.Behavioral.Visitor.AudioEditor
{
    internal class ReverbFilter : IFilter
    {
        public void ApplyTo(FormatSegment formatSegment)
        {
            Console.WriteLine("Reverb-Format Segment");
        }

        public void ApplyTo(FactSegment factSegment)
        {
            Console.WriteLine("Reverb -Fact Segment");
        }
    }
}
