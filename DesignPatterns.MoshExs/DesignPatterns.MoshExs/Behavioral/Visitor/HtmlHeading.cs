

namespace DesignPatterns.MoshExs.Behavioral.Visitor
{
    public class HtmlHeading : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
