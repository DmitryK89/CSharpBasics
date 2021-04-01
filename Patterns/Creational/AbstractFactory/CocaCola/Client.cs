namespace Patterns.Creational.AbstractFactory.CocaCola
{
    public class Client
    {
        private AbstractWater _water;
        private AbstractBottle _bottle;

        public Client(AbstractFactory factory)
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