using Newtonsoft.Json;

namespace FlareSolverrSharp.Types
{
    public class FlareSolverrRequestProxy
    {
        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("password")]
        public string? Password { get; set; }
    }
}