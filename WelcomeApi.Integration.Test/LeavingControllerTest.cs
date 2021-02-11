using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace WelcomeApi.Integration.Test
{
    public class LeavingControllerTest : IClassFixture<HttpClientBase>
    {
        public readonly HttpClientBase ClientBase;
        public WebApplicationFactory<Startup> appFactory;
        public HttpClient HttpClient => this.ClientBase.HttpClient;


        public LeavingControllerTest(HttpClientBase httpClientBase)
        {
            ClientBase = httpClientBase;
        }

        [Fact]
        public async Task DefaultRoute_ShouldReturnGoodByeString()
        {
            var req = await HttpClient.GetAsync("/api/leaving");

            Assert.True(req.IsSuccessStatusCode);
            var response = await req.Content.ReadAsStringAsync();

            Assert.Equal("Goodbye", response);
        }

    }
}
