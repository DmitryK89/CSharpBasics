using Patterns.Creational.Singleton;
using Xunit;

namespace Patterns.Creational.FactoryMethod.General
{
    public class TestSingleton
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            
            //Act
            var singletonLock = SingletonLock.Instance;
            var singletonLock2 = SingletonLock.Instance;
            
            //Assert
            Assert.IsType<SingletonLock>(singletonLock);
            Assert.True(singletonLock.Equals(singletonLock2));
        }
    }
}