
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
        }    
    }
}
