namespace Patterns.Structural.Proxy
{
    public class RealStorage : ILoader
    {
        public string Load()
        {
            return "LoadedObject";
        }
    }
}