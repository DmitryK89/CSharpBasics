using Xunit;

namespace Nutshell.Ch2LanguageBasics
{
    public class NumericTypesCompilerDefault
    {
        [Fact]
        public void FloatPointDefault()
        {
            //Arrange
            var a = 1.0;
            var b = 1E06;
            
            //Act
            var type = a.GetType();

            //Assert
            Assert.IsType<double>(a);
            Assert.IsType<double>(b);
            Assert.Equal(typeof(double),type);
        }
        
        [Fact]
        public void IntegerTypeDefault()
        {
            //Arrange
            var intValue = 1;
            var uintValue =  0xF0000000;
            var longValue = 0x100000000;
            
            //Act

            //Assert
            Assert.IsType<System.Int32>(intValue);
            Assert.IsType<System.UInt32>(uintValue);
            Assert.IsType<System.Int64>(longValue);
            
            // type is the first type in this list that can fit the literal’s
            // value: int, uint, long, and ulong
        }
    }
}