namespace Patterns.Behavioral.Visitor.Santa
{
    public interface IElement
    {
        public string Accept(IVisitor visitor);
    }
}