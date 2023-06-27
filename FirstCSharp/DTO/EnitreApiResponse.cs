using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using FirstCSharp.DTO.RootDataWithModel;
using static FirstCSharp.DTO.RootDataWithModel.Model.Client;

namespace FirstCSharp.DTO
{
    public class EnitreApiResponse<T> where T : ContainerInterface
    {
        [JsonPropertyName("success")]
        public required bool IsSuccess { get; set; }
        [JsonPropertyName("message")]
        public required string Message { get; set; }
        [JsonPropertyName("data")]
        public required T Data { get; set; }
    }
}
