using System;
using Xunit;

namespace Nutshell.Ch2LanguageBasics
{
    public class ArifmeticOperations
    {
        [Fact]
        public void IncrementDecrement()
        {
            //Arrange
            var x = 2;
            var y = 0;
            
            //Act
            x--;
            y++;
            //Assert
            Assert.Equal(1,x);
            Assert.Equal(1,y);
            
            Assert.Equal(1,x++); //compare 1=1 true, then x become 2
            Assert.Equal(2,x); //compare 2=2 true
        }
        
        [Fact]
        public void  DivideByZeroException()
        {
            //Arrange
            var a = 1;
            var b = 0;
            
            //Act

            //Assert
            Assert.Throws<DivideByZeroException>(() => a / b);
        }
        
        [Fact]
        public void  Overflow()
        {
            //Arrange
            int a = int.MinValue;
            
            //Act
           a--;
            
            //Assert
            Assert.Equal(int.MaxValue,a);
        }
        
        [Fact]
        public void  OverflowChecked()
        {
            //Arrange
            var a = int.MinValue;
            
            //Act
            Action testMethod = delegate()
            {
                checked
                {
                    a--;
                }
            };

            //Assert
            Assert.Throws<OverflowException>(testMethod);
        }
        
        [Fact]
        public void  FloatErrors()
        {
            //Arrange
            var f = 0.1f;
            var d = 0.1m;
            
            //Act
            var resultFloat = f + f + f + f + f + f + f + f + f + f;
            var resultDecimal = d + d + d + d + d + d + d + d + d + d;
            
            //Assert
            Assert.NotEqual(1, resultFloat); //Calc error exist
            Assert.InRange(resultFloat, 0.99,1.01);

            Assert.Equal(1, resultDecimal); //No calc error
        }
    }
}