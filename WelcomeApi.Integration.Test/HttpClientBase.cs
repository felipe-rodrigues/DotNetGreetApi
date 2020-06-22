using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;

namespace WelcomeApi.Integration.Test
{
    public class HttpClientBase : IDisposable
    {

        public readonly HttpClient HttpClient;
        public WebApplicationFactory<Startup> appFactory;

        public HttpClientBase()
        {
            appFactory = new WebApplicationFactory<Startup>();

            HttpClient = appFactory.CreateClient();
        }

        public void Dispose()
        {
            appFactory.Dispose();
            HttpClient.Dispose();
        }
    }
}
