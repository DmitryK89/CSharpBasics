namespace Patterns.Behavioral.Visitor.Santa
{
    public class Visitor:IVisitor
    {
        public string VisitElementA()
        {
            return "Element A visited";
        }

        public string VisitElemenB()
        {
            return "Element B visited";
        }
    }
}