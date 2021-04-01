namespace Patterns.Creational.AbstractFactory.CocaCola
{
    public class PepsiBottle : AbstractBottle
    {
        public override string Interact(AbstractWater water)
        {
            return "Pepsi";
        }
    }
}