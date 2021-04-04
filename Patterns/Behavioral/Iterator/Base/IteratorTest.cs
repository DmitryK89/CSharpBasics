using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Xunit;

namespace Patterns.Behavioral.Iterator.Base
{
    public class IteratorTest
    {
        [Fact]
        public void BasicTest()
        {
            IEnumerable enumerable = new EnumerableCollection();
            IEnumerator enumerator = enumerable.GetEnumerator();
            var result = new List<int>();
            
            while (enumerator.MoveNext())
            {
                if (enumerator.Current != null) result.Add((int) enumerator.Current);
            }
            
            Assert.Equal( new int[] {1,2,3} , result.ToArray());
        }
    }
}