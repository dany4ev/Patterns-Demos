using Patterns_Demo.SOLID_Patterns.Dependency_Inversion_Principle.Abstractions;
using System.Net.Http.Headers;

namespace Patterns_Demo.SOLID_Patterns.Dependency_Inversion_Principle.Services
{
    public class HttpService : HttpClient, IConnection
    {
        private HttpClient HttpClient;
        HttpResponseMessage HttpResponseMessage;
        HttpRequestMessage HttpRequestMessage;

        public async Task<HttpResponseMessage> Request(string url, string type, MediaTypeWithQualityHeaderValue opts,
            HttpContent? content = null)
        {
            HttpClient = new HttpClient();

            // Set the request content type
            HttpClient.DefaultRequestHeaders.Accept.Add(opts);

            if (!string.IsNullOrEmpty(type))
            {
                type = type.ToLower();
                var requestUrl = new Uri(url);

                await GetReponseByHttpMethodType(type, content, requestUrl);
            }

            return HttpResponseMessage;
        }

        private async Task GetReponseByHttpMethodType(string type, HttpContent? content, Uri requestUrl)
        {
            switch (type)
            {
                case "get":
                    HttpResponseMessage = await HttpClient.GetAsync(requestUrl);
                    break;
                case "post":
                    HttpResponseMessage = await HttpClient.PostAsync(requestUrl, content);
                    break;
                case "put":
                    HttpResponseMessage = await HttpClient.PutAsync(requestUrl, content);
                    break;
                case "delete":
                    HttpResponseMessage = await HttpClient.DeleteAsync(requestUrl);
                    break;
                default:
                    HttpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUrl);
                    HttpResponseMessage = await HttpClient.SendAsync(HttpRequestMessage);
                    break;
            }
        }
    }
}

