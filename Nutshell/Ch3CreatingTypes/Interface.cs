using System.Collections;
using Xunit;

namespace Nutshell.Ch3CreatingTypes
{
    public class CountDown : IEnumerator
    {
        private int count = 11;
        
        public bool MoveNext() => count-- > 0;

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public object Current => count;
    }
    
    public class Interface
    {
        [Fact]
        public void IEnumeratorTest()
        {
            //Arrange
            IEnumerator e = new CountDown();
            
            //Act
            var result = "";

            while (e.MoveNext())
            {
                result += e.Current;
            }
            
            //Assert
            Assert.Equal("109876543210",result);
        }
        
    }
}