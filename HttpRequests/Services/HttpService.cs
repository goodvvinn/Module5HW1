using System.Net.Http;
using System.Threading.Tasks;

namespace HttpRequests.Services
{
    public class HttpService
    {
        public HttpService()
        {
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage)
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.SendAsync(requestMessage);
            return response;
        }
    }
}