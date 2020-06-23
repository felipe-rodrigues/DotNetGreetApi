using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace WelcomeApi.Integration.Test
{
    public class WelcomeControllerTest : IClassFixture<HttpClientBase>
    {
        public readonly HttpClientBase ClientBase;
        public WebApplicationFactory<Startup> appFactory;
        public HttpClient HttpClient => this.ClientBase.HttpClient;

        public WelcomeControllerTest(HttpClientBase httpClientBase)
        {
            ClientBase = httpClientBase;
        }


        [Fact]
        public async Task DefaultRoute_ShouldReturnHelloWorldString()
        {
            var req = await HttpClient.GetAsync("/api/welcome");

            Assert.True(req.IsSuccessStatusCode);
            var response = await req.Content.ReadAsStringAsync();

            Assert.Equal("Hello World", response);
        }


        [Fact]
        public async Task HiRoute_ShouldReturnHiString()
        {
            var req = await HttpClient.GetAsync("/api/welcome/hi");

            Assert.True(req.IsSuccessStatusCode);
            var response = await req.Content.ReadAsStringAsync();

            Assert.Equal("Hi", response);
        }

        [Fact]
        public async Task OlaRoute_ShouldReturnOlaString()
        {
            var req = await HttpClient.GetAsync("/api/welcome/ola");

            Assert.True(req.IsSuccessStatusCode);
            var response = await req.Content.ReadAsStringAsync();

            Assert.Equal("Ola", response);
        }
    }
}
