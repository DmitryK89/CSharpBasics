namespace Patterns.Structural.Proxy.ProxyBase
{
    public class ProxyStorage: ILoader
    {
        private string _cache;
        private RealStorage _realStorage = new RealStorage();

        public string Load()
        {
            if (_cache != null) return "From cache " + _cache;
            _cache = _realStorage.Load();
            return _cache;
        }
    }
}