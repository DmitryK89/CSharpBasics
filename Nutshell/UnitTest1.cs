using System;
using System.Collections.Generic;
using Xunit;

namespace Nutshell
{
    public static class Test
    {
       public static Dictionary<long, string> Cache = new Dictionary<long, string>();
    }
    
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(0,Test.Cache.Count);
        }
    }
}