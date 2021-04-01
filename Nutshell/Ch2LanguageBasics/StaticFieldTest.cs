using Xunit;

namespace Nutshell.Ch2LanguageBasics
{
   
    public class StaticFieldTest
    {
        private class Panda
        {
            public string Name { get; } //InstanceField
     
            public static int Population { get; private set; } //StaticFields

            public Panda(string name)
            {
                Name = name;
                Population++;
            }
        }
        
        [Fact]
        public void CustomTypeBasicFunctionality()
        {
            //Arrange
            var p1 = new Panda("Pan Dee");
            var p2 = new Panda("Pan Dah");
            
            //Act
            
            //Assert
            Assert.Equal(2, Panda.Population);
            Assert.Equal("Pan Dee", p1.Name);
            Assert.Equal("Pan Dah", p2.Name);
        }
    }
}