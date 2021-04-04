namespace Patterns.Behavioral.Visitor.Santa
{
    public class ElementB : IElement
    {
        public string Accept(IVisitor visitor)
        {
            return visitor.VisitElemenB();
        }
    }
}