using Xunit;

namespace Patterns.Creational.AbstractFactory.CocaCola
{
    public class TestAbstractFactory
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var colaClient = new Client (new CocaColaFactory());
            var pepsiClient = new Client (new PepsiFactory());
            
            //Act
            var cocaCola = colaClient.Run();
            var pepsi = pepsiClient.Run();
            
            //Assert
            Assert.Equal("CocaCola", cocaCola);
            Assert.Equal("Pepsi", pepsi);
        }
    }
}