using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FirstCSharp.DTO.RootDataWithModel.Model
{
    public class PetType
    {
        [JsonPropertyName("id")]
        public required string Id { get; set; }
        [JsonPropertyName("title")]
        public required string Title { get; set; }
        [JsonPropertyName("picture")]
        public required string Picture { get; set; }
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
