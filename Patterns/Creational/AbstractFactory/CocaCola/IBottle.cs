using System.ComponentModel.Design;

namespace Patterns.Creational.AbstractFactory.CocaCola
{
    public interface IBottle
    {
        public string Interact(IWater water);
    }
}