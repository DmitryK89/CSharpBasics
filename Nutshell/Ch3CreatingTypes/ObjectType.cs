using System;
using Xunit;

namespace Nutshell.Ch3CreatingTypes
{
    public class ObjectType
    {
        [Fact]
        public void BoxingAndUnboxing()
        {
            //Arrange
            var x = 9;
            
            //Act
            object obj = x; //box unit
            var y = (int) obj; //unbox int
            
            //Assert
            Assert.Equal(9,y);
            Assert.IsType<int>(obj);
        }
        
        [Fact]
        public void GetType1()
        {
            //Arrange
            object obj = 1;
            var x = 1;

            //Act
            var objectRuntime = obj.GetType().Name; //at runtime
            var objectCompileTime = typeof(Object).Name; //at compile time
            var intRuntime = x.GetType().Name; //at runtime
            var intCompileTime = typeof(int).Name; //at compile time

            //Assert
            Assert.Equal("Int32",objectRuntime);
            Assert.Equal("Object",objectCompileTime);
            Assert.Equal("Int32",intRuntime);
            Assert.Equal("Int32",intCompileTime);

        }
    }
}