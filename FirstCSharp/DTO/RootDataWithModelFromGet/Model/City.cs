using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FirstCSharp.DTO.RootDataWithModel.Model
{
    public class City : AbstractModel
    {
        [JsonPropertyName("title")]
        public required string Title { get; set; }
        [JsonPropertyName("type_id")]
        public required string? TypeId { get; set; }
    }
}
