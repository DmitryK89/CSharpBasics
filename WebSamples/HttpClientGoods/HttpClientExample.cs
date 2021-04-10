using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WebSamples.HttpClientGoods.Model;
using Xunit;

namespace WebSamples.HttpClientGoods
{
    public class HttpClientExample
    {
        private readonly HttpClient _client;

        private readonly JsonSerializerOptions _options;

        public HttpClientExample()
        {
            _client = new HttpClient();
            _options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
        }

        [Fact]
        public async Task HttpClientTest()
        {
            HttpResponseMessage responseMessage = await _client.GetAsync("http://chelhack.deletestaging.com/goods");
            
            Assert.True(responseMessage.IsSuccessStatusCode);

            responseMessage.EnsureSuccessStatusCode();
            
            var jsonString = await responseMessage.Content.ReadAsStringAsync();

            //Serializing
            
            var goods = JsonSerializer.Deserialize<Root>(jsonString, _options);
            
            //Filtering
            
            var p = new Parameter
            {
                Title = "SIM",
                Value = "3"
            };

            var filteredResults = goods?.Data
                .Where(x => x.Parameters.Any(y => y.Title == p.Title 
                                                                && y.Value == p.Value))
                .ToArray();
            
            Assert.Equal(8,filteredResults?.Length);
        }
    }
}