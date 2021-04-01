using Xunit;

namespace Nutshell.Ch2LanguageBasics
{
    public class Strings
    {
        [Fact]
        public void StringEquality()
        {
            //Arrange
            string a = "test";
            string b = "test";
            
            //Act
            
            //Assert
            Assert.Equal(a, b);
            
            //string is a reference type rather than a value type. Its equality
            //operators, however, follow value-type semantics:
        }
        
       [Fact]
        public void VerbatimStringLiterals()
        {
            //Arrange
            
            //The cost of this is that whenever you need a literal backslash, you must write it twice:
            
            string a =  "\\\\server\\fileshare\\helloworld.cs";
            
            //To prevent this problem, C# allows verbatim string literals. A verbatim string literal
            //is prefixed with @ and does not support escape sequences. The following verbatim
            //string is identical to the preceding one:
            
            string b = @"\\server\fileshare\helloworld.cs";
            
            //A verbatim string literal can also span multiple lines:
            string escaped = "First Line\r\nSecond Line";
            string verbatim = @"First Line
Second Line";
            
            //You can include the double-quote character in a verbatim literal by writing it twice:
            string xml = @"<customer id=""123""></customer>";
            
            //Act
            
            //Assert
            Assert.Equal(a, b);
            Assert.Equal(escaped, verbatim);
            
            //string is a reference type rather than a value type. Its equality
            //operators, however, follow value-type semantics:
        }
        
        [Fact]
        public void StringConcatenation()
        {
            //Arrange
            string a =  "a";
            string b =  "b";
            int c = 5;

            //Act
            string ab = a + b;
            string a5 = a + 5;
            
            //Assert
            Assert.Equal("ab", ab);
            Assert.Equal("a5", a5);
        }
        
        [Fact]
        public void StringInterpolation()
        {
            //Arrange
            int x = 4;

            //Act
            string result = $"A square has {x} sides";

            //Assert
            Assert.Equal("A square has 4 sides", result);
            
            //Another Examples
            bool b = true;
            string example1 = $"The answer in binary is {(b ? 1 : 0)}"; // Evaluates to "The answer in binary is 1"
            
            string example2 = $"255 in hex is {byte.MaxValue:X2}"; // Evaluates to "255 in hex is FF"
           
            string example3 = $@"this spans { // Evaluates to "this spans 4 lines"
                x} lines";
        }
    }
}