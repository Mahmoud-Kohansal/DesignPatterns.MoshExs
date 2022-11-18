

namespace DesignPatterns.MoshExs.Behavioral.Visitor
{
    public interface IOperation
    {
        public void Apply(HtmlHeading htmlHeading);
        public void Apply(HtmlAnchor htmlAnchor);
    }
}
