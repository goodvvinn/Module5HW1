using Newtonsoft.Json;

namespace HttpRequests.DTO
{
    public class RegResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
