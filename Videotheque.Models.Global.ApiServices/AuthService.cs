using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using Videotheque.Models.Global.Entities;
using Videotheque.Models.Interfaces;

namespace Videotheque.Models.Global.ApiServices
{
    public class AuthService : IAuthService<User>
    {
        HttpClient _httpClient;
        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public void Register(User user)
        {
            string json = JsonConvert.SerializeObject(new { user.LastName, user.FirstName, user.Email, user.Passwd });
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage responseMessage = _httpClient.PostAsync("auth/register", httpContent).Result;
            responseMessage.EnsureSuccessStatusCode();
        }
    }
}
