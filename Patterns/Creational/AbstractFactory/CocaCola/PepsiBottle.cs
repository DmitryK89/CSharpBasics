namespace Patterns.Creational.AbstractFactory.CocaCola
{
    public class PepsiBottle : IBottle
    {
        public string Interact(IWater water)
        {
            return "Pepsi";
        }
    }
}