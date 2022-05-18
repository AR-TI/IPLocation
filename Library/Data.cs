using System.Text.Json.Serialization;

namespace IPLocation
{
    public class Data
    {
        [JsonPropertyName("query")]
        public string? IP { get; set; }
        [JsonPropertyName("continent")]
        public string? Continent { get; set; }
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        [JsonPropertyName("regionName")]
        public string? Region { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}
