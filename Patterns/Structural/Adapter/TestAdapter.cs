using Patterns.Creational.Singleton;
using Xunit;

namespace Patterns.Structural.Adapter
{
    public class TestAdapter
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            ITarget target = new Adapter();
            
            //Act
            var result = target.Request("Test");
            
            //Assert
            Assert.Equal("Accepted", result);
        }
    }
}