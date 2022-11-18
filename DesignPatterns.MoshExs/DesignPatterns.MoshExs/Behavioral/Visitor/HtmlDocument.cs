
namespace DesignPatterns.MoshExs.Behavioral.Visitor
{
    public class HtmlDocument
    {
        List<IHtmlNode> _HtmlNodes = new();
        public HtmlDocument()
        {

        }
        public HtmlDocument(List<IHtmlNode> nodes)
        {
            _HtmlNodes.AddRange(nodes);
        }
        public void AddNode(IHtmlNode htmlNode)
        {
            _HtmlNodes.Add(htmlNode);
        }

        public void ApplyOperation(IOperation operation)
        {
            foreach (var node in _HtmlNodes)
            {
                node.Execute(operation);
            }
        }        
    }
}
