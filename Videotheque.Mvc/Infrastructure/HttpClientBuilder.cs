using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Security.Authentication;
using System.Threading.Tasks;

namespace Videotheque.Mvc.Infrastructure
{
    internal static class HttpClientBuilder 
    {
        internal static HttpClient Build()
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                SslProtocols = SslProtocols.Tls12
            };

            handler.ServerCertificateCustomValidationCallback += (request, cert, chain, errors) =>
            {
                return true;
            };


            HttpClient httpClient = new HttpClient(handler);
            httpClient.BaseAddress = new Uri("https://localhost:5001/api/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return httpClient;
        }
    }
}
