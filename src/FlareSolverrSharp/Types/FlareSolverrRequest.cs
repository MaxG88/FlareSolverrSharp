using Newtonsoft.Json;

namespace FlareSolverrSharp.Types
{
    public class FlareSolverrRequest
    {
        [JsonProperty("cmd")]
        public string? Cmd { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("session")]
        public string? Session { get; set; }

        [JsonProperty("proxy")]
        public FlareSolverrRequestProxy? Proxy { get; set; }
    }
}