using System;
using System.Linq;

namespace Patterns.Behavioral.Strategy.Base
{
    public class SortByAscending : ISort
    {
        public void Sort(ref int[] array)
        {
            array = array.OrderBy(x=>x).ToArray();
        }
    }
}