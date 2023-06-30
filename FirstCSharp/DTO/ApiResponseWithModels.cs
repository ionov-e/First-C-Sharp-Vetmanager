using FirstCSharp.DTO.RootDataWithModel;
using System.Text.Json.Serialization;

namespace FirstCSharp.DTO
{
    internal class ApiResponseWithModels<T> where T : ContainerInterface
    {
        [JsonPropertyName("success")]
        public required bool IsSuccess { get; set; }
        [JsonPropertyName("message")]
        public required string Message { get; set; }
        [JsonPropertyName("data")]
        public required T Data { get; set; }
    }
}
