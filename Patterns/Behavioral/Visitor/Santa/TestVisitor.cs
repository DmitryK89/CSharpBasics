using Xunit;

namespace Patterns.Behavioral.Visitor.Santa
{
    public class TestVisitor
    {
        [Fact]
        public void SantaTest()
        {
            //Arrange
            var visitCollection = new VisitCollection();
            visitCollection.Add(new ElementA());
            visitCollection.Add(new ElementB());
            var visitor = new Visitor();
            
            //Act
            string[] result = visitCollection.Apply(visitor);
            
            //Assert
            Assert.Equal(new string[]{"Element A visited","Element B visited"}, result);
        }
    }
}