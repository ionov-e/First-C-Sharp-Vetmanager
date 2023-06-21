using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstCSharp.DTO
{
    public class ClientListData : ModelDataInterface
    {
        public required string totalCount { get; set; }
        public int TotalNumber
        {
            get { return Int32.Parse(totalCount); }
            set { totalCount = value.ToString(); }
        }
        [JsonPropertyName("client")]
        public required Client[] Clients { get; set; }
    }
}
