using Newtonsoft.Json;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnassignedField.Global
// ReSharper disable ClassNeverInstantiated.Global
namespace FlareSolverrSharp.Types
{
    public class FlareSolverrResponse
    {
        public string? Status { get; set; }

        public string? Message { get; set; }

        public long StartTimestamp { get; set; }

        public long EndTimestamp { get; set; }

        public string? Version { get; set; }

        public Solution? Solution { get; set; }

        public string? Session { get; set; }

        public string[]? Sessions { get; set; }
    }

    public class Solution
    {
        public string? Url { get; set; }

        public string? Status { get; set; }

        public Headers? Headers { get; set; }

        public string? Response { get; set; }

        public Cookie[]? Cookies { get; set; }

        public string? UserAgent { get; set; }
    }

    public class Cookie
    {
        public string? Name { get; set; }

        public string? Value { get; set; }

        public string? Domain { get; set; }

        public string? Path { get; set; }

        public double Expires { get; set; }

        public int Size { get; set; }

        public bool HttpOnly { get; set; }

        public bool Secure { get; set; }

        public bool Session { get; set; }

        public string? SameSite { get; set; }

        public string ToHeaderValue() => $"{Name}={Value}";

        public System.Net.Cookie ToCookieObj() => new System.Net.Cookie(Name ?? "", Value);
    }

    public class Headers
    {
        public string? Status { get; set; }

        public string? Date { get; set; }

        [JsonProperty(PropertyName = "content-type")]
        public string? ContentType { get; set; }
    }
}