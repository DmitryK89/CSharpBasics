namespace Patterns.Creational.AbstractFactory.CocaCola
{
    public interface IFactory
    {
        public IWater CreateWater();
        public IBottle CreateBottle();
    }
}