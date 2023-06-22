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
    public class PetData : ModelDataInterface
    {
        public required int totalCount { get; set; }
        public int TotalNumber
        {
            get { return totalCount; }
            set { totalCount = value; }
        }
        [JsonPropertyName("pet")]
        public required Pet Pet { get; set; }
    }
}
