using DotNetIntegrationTestCI;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace WelcomeApi.Integration.Test
{
    public class WelcomeControllerTest
    {
        public readonly HttpClient HttpClient;
        public WebApplicationFactory<Startup> appFactory;

        public WelcomeControllerTest()
        {
            appFactory = new WebApplicationFactory<Startup>();

            HttpClient = appFactory.CreateClient();
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
        public async Task DefaultRoute_ShouldReturnHiString()
        {
            var req = await HttpClient.GetAsync("/api/welcome/hi");

            Assert.True(req.IsSuccessStatusCode);
            var response = await req.Content.ReadAsStringAsync();

            Assert.Equal("Hi", response);
        }
    }
}
