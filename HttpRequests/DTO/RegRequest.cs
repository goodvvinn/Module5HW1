using Newtonsoft.Json;

namespace HttpRequests.DTO
{
    public class RegRequest
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
