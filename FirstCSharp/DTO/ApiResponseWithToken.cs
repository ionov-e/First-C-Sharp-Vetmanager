using System.Text.Json.Serialization;

namespace FirstCSharp.DTO
{
    public class ApiResponseWithToken
    {
        [JsonPropertyName("status")]
        public required int Status { get; set; }
        [JsonPropertyName("title")]
        public required string Title { get; set; }
        [JsonPropertyName("detail")]
        public required string Detail { get; set; }
        [JsonPropertyName("data")]
        public required DataWithToken Data { get; set; }

        public class DataWithToken
        {
            [JsonPropertyName("service")]
            public required string Service { get; set; }
            [JsonPropertyName("token")]
            public required string Token { get; set; }
            [JsonPropertyName("user_id")]
            public required string UserId { get; set; }
        }
    }


}
