namespace Patterns.Creational.AbstractFactory.CocaCola
{
    public class CocaColaBottle : IBottle
    {
        public string Interact(IWater water)
        {
            return "CocaCola";
        }
    }
}