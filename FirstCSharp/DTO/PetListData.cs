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
    public class PetListData : ModelDataInterface
    {
        public required string totalCount { get; set; }
        public int TotalNumber
        {
            get { return Int32.Parse(totalCount); }
            set { totalCount = value.ToString(); }
        }
        [JsonPropertyName("pet")]
        public required Pet[] Pets { get; set; }
    }
}
