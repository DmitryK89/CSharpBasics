using Xunit;

namespace Patterns.Structural.Fasade
{
    public class TestFacade
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var facade = new Facade();
            
            //Act
            var resultAB = Facade.OperationAB();
            var resultBC = Facade.OperationBC();
            
            //Assert
            Assert.Equal("AB", resultAB);
            Assert.Equal("BC", resultBC);
        }
    }
}