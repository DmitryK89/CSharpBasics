namespace Patterns.Creational.AbstractFactory.CocaCola
{
    public class CocaColaFactory : IFactory
    {
        public IWater CreateWater()
        {
            return new CocaColaWater();
        }

        public IBottle CreateBottle()
        {
            return new CocaColaBottle();
        }
    }
}