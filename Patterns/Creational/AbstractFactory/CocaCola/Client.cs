namespace Patterns.Creational.AbstractFactory.CocaCola
{
    public class Client
    {
        private IWater _water;
        private IBottle _bottle;

        public Client(IFactory factory)
        {
            _water = factory.CreateWater();
            _bottle = factory.CreateBottle();
        }

        public string Run()
        {
            return _bottle.Interact(_water);
        }
    }
}