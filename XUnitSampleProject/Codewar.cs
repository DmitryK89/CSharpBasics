using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitSampleProject
{
    public static class Filter
    {
        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

            return birds.Except(geese);
        }
        
        [Fact]
        public static void SampleTest()
        {
            Assert.Equal(new string[] {"Mallard", "Hook Bill", "Crested", "Blue Swedish"},
                GooseFilter(new string[] {"Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish"}));
          
            Assert.Equal(new string[] {"Mallard", "Barbary", "Hook Bill", "Blue Swedish", "Crested"},
                GooseFilter(new string[] {"Mallard", "Barbary", "Hook Bill", "Blue Swedish", "Crested"}));
          
            Assert.Equal(new string[] {}, 
                GooseFilter(new string[] {"African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher"}));
        }
    }
    
    
}