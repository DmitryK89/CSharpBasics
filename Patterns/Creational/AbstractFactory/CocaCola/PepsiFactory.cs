namespace Patterns.Creational.AbstractFactory.CocaCola
{
    public class PepsiFactory : AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new PepsiWater();;
        }

        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }
    }
}