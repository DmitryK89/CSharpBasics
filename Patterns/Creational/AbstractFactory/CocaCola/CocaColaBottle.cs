namespace Patterns.Creational.AbstractFactory.CocaCola
{
    public class CocaColaBottle : AbstractBottle
    {
        public override string Interact(AbstractWater water)
        {
            return "CocaCola";
        }
    }
}