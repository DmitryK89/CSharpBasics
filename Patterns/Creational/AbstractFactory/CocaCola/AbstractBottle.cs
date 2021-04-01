using System.ComponentModel.Design;

namespace Patterns.Creational.AbstractFactory.CocaCola
{
    public abstract class AbstractBottle
    {
        public abstract string Interact(AbstractWater water);
    }
}