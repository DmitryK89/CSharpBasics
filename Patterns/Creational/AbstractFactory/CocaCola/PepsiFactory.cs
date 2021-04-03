namespace Patterns.Creational.AbstractFactory.CocaCola
{
    public class PepsiFactory : IFactory
    {
        public IWater CreateWater()
        {
            return new PepsiWater();;
        }

        public IBottle CreateBottle()
        {
            return new PepsiBottle();
        }
    }
}