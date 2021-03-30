using Xunit;

namespace Nutshell.Ch2LanguageBasics.Part1TypeBasic
{
    public class UnitConverter
    {
        private readonly int _ratio; //Field

        public UnitConverter(int unitRatio)
        {
            _ratio = unitRatio; //Constructor
        }

        public int Convert(int unit)
        {
            return unit * _ratio;
        }
    }
    
    public class CustomTypes
    {
        [Fact]
        public void CustomTypeBasicFunctionality()
        {
            //Arrange
            var metersToCentimeters = new UnitConverter(100);
            
            //Act
            var result = metersToCentimeters.Convert(1);

            //Assert
            Assert.Equal(100, result);
        }
    }
}