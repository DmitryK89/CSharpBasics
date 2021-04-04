using System;
using System.Linq;

namespace Patterns.Behavioral.Strategy.Base
{
    public class SortByDescending : ISort
    {
        public void Sort(ref int[] array)
        {
            array = array.OrderByDescending(x=>x).ToArray();
        }
    }
}