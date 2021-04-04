namespace Patterns.Behavioral.Visitor.Santa
{
    public class ElementA : IElement
    {
        public string Accept(IVisitor visitor)
        {
            return visitor.VisitElementA();
        }
    }
}