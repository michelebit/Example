using Example.Rest.Security;
using System;
using System.Net.Http;

namespace Example.Rest
{
    public abstract class RestClient
    {
        public static HttpClient Client { get; set; } = new HttpClient(new TokenExpiredHandler(new HttpClientHandler()));
        
        public RestClient()
        {
            Client.BaseAddress = Properties.Endpoint;
            Client.MaxResponseContentBufferSize = 256000;
        }
    }
}
