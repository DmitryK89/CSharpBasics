using System;
using System.Threading;

namespace Patterns.Creational.Singleton
{
    public class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> _instance = new Lazy<SingletonLazy>();
        public static SingletonLazy Instance => _instance.Value;
    }
}