using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HttpRequests.DTO;
using HttpRequests.Interfaces;
using HttpRequests.Services;
using Newtonsoft.Json;

namespace HttpRequests
{
    public class Sender : ISend
    {
        private readonly AuthorisationService _authorisationService;
        public Sender()
        {
            _authorisationService = new AuthorisationService();
        }

        public async Task SendAsync()
        {
                using (var httpClient = new HttpClient())
                {
                    var payload = new
                    {
                        name = "morpheus",
                        job = "leader"
                    };

                    var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

                    var httpMessage = new HttpRequestMessage
                    {
                        Content = httpContent,
                        RequestUri = new Uri(@"https://reqres.in/api/users"),
                        Method = HttpMethod.Post
                    };

                    var result = await httpClient.SendAsync(httpMessage);

                    if (result.StatusCode == HttpStatusCode.Created)
                    {
                        var content = await result.Content.ReadAsStringAsync();
                        var respose = JsonConvert.DeserializeObject<ResponseUserDto>(content);
                        Console.WriteLine(respose.Name.ToString());
                    }
                }
            }
    }
}
