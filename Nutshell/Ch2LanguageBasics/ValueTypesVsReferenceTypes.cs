using Xunit;

namespace Nutshell.Ch2LanguageBasics
{

    public class ValueTypesVsReferenceTypes
    {
        private struct PointStruct
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        
        private class PointClass
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        
        [Fact]
        public void ValueTypesAssigmentCopyValue()
        {
            //Arrange
            var p1 = new PointStruct {X = 7, Y = 7};

            //Act
            var p2 = p1; //Assignment causes copy
            p2.Y = 8; //Changed only in p2
            
            //Assert
            Assert.Equal(7, p1.X);
            Assert.Equal(7, p1.Y);
            Assert.Equal(7, p2.X);
            Assert.Equal(8, p2.Y); 
            /*Value p2 and p1 is different*/
        }
        
        [Fact]
        public void ValueTypesAssigmentCopyReference()
        {
            //Arrange
            var p1 = new PointClass() {X = 7, Y = 7};

            //Act
            var p2 = p1; //Assignment causes copy
            p2.Y = 8; //Changed in p2 and p1
            
            //Assert
            Assert.Equal(7, p1.X);
            Assert.Equal(8, p1.Y); 
            Assert.Equal(7, p2.X);
            Assert.Equal(8, p2.Y);
            /*Value p2 and p1 are the same*/
        }
        
        [Fact]
        public void NullReferenceVsValue()
        {
            //Arrange
            PointClass p1 = null;
            //PointStruct p2 = null; - cause to compile time error, value types cannot be Null
            PointStruct? p3 = null; //Value type can be converted to Reference with ?
            
            //int p4 = null; - cause to compile time error, value types cannot be Null
            int? p5 = null; //Value type can be converted to Reference with ?
            
            //Act
            
            //Assert
            Assert.Null(p1);
            Assert.Null(p3); 
            Assert.Null(p5); 
        }
    }
}