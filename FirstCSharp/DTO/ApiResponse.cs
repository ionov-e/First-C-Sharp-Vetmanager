using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static FirstCSharp.DTO.Client;

namespace FirstCSharp.DTO
{
    public class ApiResponse<T> where T : AbstractModelData
    {
        [JsonPropertyName("success")]
        public required bool IsSuccess { get; set; }
        [JsonPropertyName("message")]
        public required string Message { get; set; }
        [JsonPropertyName("data")]
        public required T Data { get; set; }
    }
}
