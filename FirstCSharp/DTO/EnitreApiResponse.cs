using System.Text.Json.Serialization;
using FirstCSharp.DTO.RootDataWithModel;

namespace FirstCSharp.DTO
{
    internal class EnitreApiResponse<T> where T : ContainerInterface
    {
        [JsonPropertyName("success")]
        public required bool IsSuccess { get; set; }
        [JsonPropertyName("message")]
        public required string Message { get; set; }
        [JsonPropertyName("data")]
        public required T Data { get; set; }
    }
}
