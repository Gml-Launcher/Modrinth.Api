using System;
using System.Net.Http;

namespace Modrinth.Api.Core.System;

public class HttpClientFactory
{
    internal HttpClientFactory(int timeout)
    {
        HttpClient = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(timeout),
            BaseAddress = new Uri("https://api.modrinth.com/v2/search")
        };
    }

    public HttpClient HttpClient { get; }
}
