using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;
using Xunit;

namespace Web.HttpClientTemplate
{
    public class HttpClientTemplate
    {
        [Fact]
        public void HttpClientTest()
        {
            //using HttpClient client = new HttpClient();
            
            //HttpResponseMessage responseMessage = await client.GetAsync("http://chelhack.deletestaging.com/goods");

            //Assert.True(responseMessage.IsSuccessStatusCode);
            
            Assert.True(true);
        }
        
        [Fact]
        public void HttpClientTest2()
        {
            var test = true;
            Assert.True(test);
        }
    }
}