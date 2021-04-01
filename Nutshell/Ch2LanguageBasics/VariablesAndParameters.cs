using System.Text;
using Xunit;

namespace Nutshell.Ch2LanguageBasics
{
    class Foo
    {
        StringBuilder sb;
 
        public Foo (string initialValue)
        {
            sb = new (initialValue);
        }
    }

    public class VariablesAndParameters
    {
        private int Factorial(int x)
        {
            if (x == 0) return 1;
            return x * Factorial(x - 1);
        }

        [Fact]
        public void TestFactorial()
        {
            //Arrange
            
            //Act
            var result = Factorial(3);
            
            //Assert
            Assert.Equal(6, result);
        }
        
        [Fact]
        public void PassingArgumentByValue()
        {
            //Arrange
            int x = 8;
            
            //Act
            Foo (x);
            static void Foo (int p)
            {
                p = p + 1; // Increment p by 1
                Assert.Equal(9, p); // Write p to screen
            }
            
            //Assert
            Assert.Equal(8, x); // Write p to screen
        }
        
        [Fact]
        public void PassingArgumentByReference()
        {
            //Arrange
            int x = 8;
            
            //Act
            Foo (ref x);
            static void Foo (ref int p)
            {
                p = p + 1; // Increment p by 1
                Assert.Equal(9, p); // Write p to screen
            }
            
            //Assert
            Assert.Equal(9, x); // Write p to screen
        }
        
        [Fact]
        public void PassingArgumentByReference2()
        {
            //Arrange
            StringBuilder sb = new StringBuilder();
            static void Foo (StringBuilder fooSB)
            {
                fooSB.Append ("test");
                fooSB = null;
            }
            
            //Act
            Foo (sb);
            string result = sb.ToString();
            
            //Assert
            Assert.Equal("test", result); // Write p to screen
        }
        
        [Fact]
        public void OutModifier()
        {
            //Arrange
            void Split (string name, out string firstNames, out string lastName)
            {
                int i = name.LastIndexOf (' ');
                firstNames = name.Substring (0, i);
                lastName = name.Substring (i + 1);
            }

            //Act
            Split ("Stevie Ray Vaughn", out string a, out string b);
            
            //Assert
            Assert.Equal("Stevie Ray", a);
            Assert.Equal("Vaughn", b);
        }
        
        [Fact]
        public void StringTest()
        {
            //Arrange
            var a = "Name";
            void ClearString (string a)
            {
                a = "";
            }

            //Act
            ClearString(a);
            
            //Assert
            Assert.Equal("Name", a);
        }
    }
}