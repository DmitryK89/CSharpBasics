using Patterns.Structural.Fasade;
using Xunit;

namespace Patterns.Structural.Proxy.ProxyBase
{
    public class TestProxy
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var proxy = new ProxyStorage();
            
            //Act
            string firstLoad = proxy.Load();
            string secondLoad = proxy.Load();
            
            //Assert
            Assert.Equal("LoadedObject", firstLoad);
            Assert.Equal("From cache LoadedObject",secondLoad);
        }
    }
}