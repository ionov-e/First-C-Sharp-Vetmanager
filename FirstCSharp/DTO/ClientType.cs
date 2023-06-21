using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FirstCSharp.DTO
{
    public class ClientType : DtoInterface
    {
        [JsonPropertyName("id")]
        public required string Id { get; set; }
        [JsonPropertyName("title")]
        public required string Title { get; set; }
    }
}
