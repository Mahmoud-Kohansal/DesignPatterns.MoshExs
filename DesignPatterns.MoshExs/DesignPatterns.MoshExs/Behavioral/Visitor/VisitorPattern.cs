
using DesignPatterns.MoshExs.Behavioral.Visitor.AudioEditor;

namespace DesignPatterns.MoshExs.Behavioral.Visitor
{
    public static class VisitorPattern
    {
        public static void Run()
        {
            HtmlDocument document = new();
            document.AddNode(new HtmlHeading());
            document.AddNode(new HtmlAnchor());
            document.ApplyOperation(new HighlightOperation());

            Console.WriteLine("---------------- Audio Editor Visitor Pattern ----------------");
            WaveFile waveFile = new();
            waveFile.AddSegment(new FactSegment());
            waveFile.AddSegment(new FormatSegment());
            waveFile.ApplyFilter(new NormalizeFilter());
            waveFile.ApplyFilter(new ReverbFilter());
        }    
    }
}
