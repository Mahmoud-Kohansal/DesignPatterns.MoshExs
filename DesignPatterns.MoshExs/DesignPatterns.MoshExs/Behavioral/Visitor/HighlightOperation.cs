
namespace DesignPatterns.MoshExs.Behavioral.Visitor
{
    public class HighlightOperation : IOperation
    {
        public void Apply(HtmlHeading htmlHeading)
        {
            Console.WriteLine("Highlight-Heading...");
        }

        public void Apply(HtmlAnchor htmlAnchor)
        {
            Console.WriteLine("Highlight-Anchor...");
        }
    }
}
