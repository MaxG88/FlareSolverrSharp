using Newtonsoft.Json;

namespace FlareSolverrSharp.Types
{
    public class FlareSolverrRequestPost : FlareSolverrRequest
    {
        [JsonProperty("postData")]
        public string? PostData { get; set; }

        [JsonProperty("maxTimeout")]
        public int MaxTimeout { get; set; }
    }
}