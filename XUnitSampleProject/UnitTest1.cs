using System;
using Xunit;

namespace XUnitSampleProject
{
    public class UnitTest1
    {
        [Fact]
        public void SampleFactTest()
        {
            //Arrange
            var input = 1;
            var expected = "1";
            
            //Act
            var result = input.ToString();
            
            //Assert
            Assert.Equal(expected,result);
        }
        
        [Theory]
        [InlineData(1,"1")]
        public void SampleTheoryTest(object input, string expected)
        {
            //Arrange
            
            //Act
            var result = input.ToString();
            
            //Assert
            Assert.Equal(expected,result);
        }
        
        
    }
}