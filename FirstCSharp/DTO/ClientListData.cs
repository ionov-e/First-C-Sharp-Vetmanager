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
    public class ClientListData : AbstractDataWithTotalCountAsString
    {
        [JsonPropertyName("client")]
        public required Client[] Clients { get; set; }
    }
}
