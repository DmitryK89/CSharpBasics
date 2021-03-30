using System;
using Xunit;

namespace CSharpBasics
{
    public class UnitTest1
    {
        [Theory]
        [InlineData((int)1, "1")]
        [InlineData(1d, "1")]
        public void ToStringTestTheory(object objectUnderTest, string expected)
        {
            // Arrange
            
            // Act
            var result = objectUnderTest.ToString();
            
            // Assert
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void ToStringTestFact()
        {
            // Arrange
            
            // Act
            var result = objectUnderTest.ToString();
            
            // Assert
            Assert.Equal(expected,result);
        }
    }
}