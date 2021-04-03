using Xunit;

namespace Patterns.Creational.FactoryMethod.General
{
    public class TestFactoryMethod
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            
            //Act
            var creator = new ConcreteCreator();
            var product = creator.FactoryMethod();
            var product2 = creator.FactoryMethod<ConcreteProduct>();
            
            //Assert
            Assert.IsType<ConcreteProduct>(product);
            Assert.IsType<ConcreteProduct>(product2);
        }
    }
}