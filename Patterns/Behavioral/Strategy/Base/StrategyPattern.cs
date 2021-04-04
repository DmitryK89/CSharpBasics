using Xunit;

namespace Patterns.Behavioral.Strategy.Base
{
    public class StrategyPattern
    {
        [Fact]
        private void StrategyTest()
        {
            //Arrange
            var contextAsc = new Context(new SortByAscending());
            var contextDesc = new Context(new SortByDescending());
            
            //Act
            var resultAsc = new int[] {1, 5, 4, 2, 3};
            contextAsc.Sort(ref resultAsc);
            
            var resultDesc = new int[] {1, 5, 4, 2, 3};
            contextDesc.Sort(ref resultDesc);
            
            //Assert
            Assert.Equal(new int[]{1,2,3,4,5},resultAsc);
            Assert.Equal(new int[]{5,4,3,2,1},resultDesc);
        }
    }
}