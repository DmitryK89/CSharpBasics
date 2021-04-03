using System;

namespace Patterns.Creational.FactoryMethod.General
{
    public class ConcreteCreator : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }
        
        public IProduct FactoryMethod<T>() where T : IProduct
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}