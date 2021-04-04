using System;
using Xunit;

namespace Nutshell.Ch3CreatingTypes
{
    class C { public void Foo() {} }
    
    public class Struct
    {
        public struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        
        [Fact]
        public void StructTest()
        {
            //Arrange
            Point p1 = default;
            
            //Act

            //Assert
            Assert.Equal(0,p1.x);
        }
    }
}