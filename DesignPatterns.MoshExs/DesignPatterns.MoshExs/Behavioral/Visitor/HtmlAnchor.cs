

namespace DesignPatterns.MoshExs.Behavioral.Visitor
{
    public class HtmlAnchor : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
