using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FirstCSharp.DTO
{
    public class PetData : AbstractDataWithTotalCountAsInt
    {
        [JsonPropertyName("pet")]
        public required Pet Pet { get; set; }
    }
}
