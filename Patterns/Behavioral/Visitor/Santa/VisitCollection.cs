using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavioral.Visitor.Santa
{
    public class VisitCollection
    {
        private List<IElement> _elements = new List<IElement>();

        public void Add(IElement element)
        {
            _elements.Add(element);
        }
        
        public void Remove(IElement element)
        {
            _elements.Remove(element);
        }

        public string[] Apply(IVisitor visitor)
        {
            var result = new List<string>();
            
            foreach (var element in _elements)
            {
                result.Add(element.Accept(visitor));
            }

            return result.ToArray();
        }
        
    }
}