using System.Collections.Generic;
using Newtonsoft.Json;

namespace HttpRequests.DTO
{
    public class UnknownResponse
    {
        [JsonProperty(PropertyName = "data")]
        public UnknownRes UnknownRes { get; set; }

        [JsonProperty(PropertyName = "support")]
        public IReadOnlyDictionary<string, string> UnknownValue { get; set; }
    }
}
