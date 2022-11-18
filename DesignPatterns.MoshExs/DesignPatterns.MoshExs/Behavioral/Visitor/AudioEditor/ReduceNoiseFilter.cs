
namespace DesignPatterns.MoshExs.Behavioral.Visitor.AudioEditor
{
    internal class ReduceNoiseFilter : IFilter
    {
        public void ApplyTo(FormatSegment formatSegment)
        {
            Console.WriteLine("Reduce Noise-Format Segment");
        }

        public void ApplyTo(FactSegment factSegment)
        {
            Console.WriteLine("Reduce Noise-Fact Segment");
        }
    }
}
