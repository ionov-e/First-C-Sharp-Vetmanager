using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer;
using System.Text.Json.Serialization;

namespace FirstCSharp.VetmanagerApiGateway.DTO
{
    internal class ApiResponseWithModelContainer<T> where T : ModelContainerInterface
    {
        [JsonPropertyName("success")]
        public required bool IsSuccess { get; set; }
        [JsonPropertyName("message")]
        public required string Message { get; set; }
        [JsonPropertyName("data")]
        public required T Data { get; set; }
    }
}
