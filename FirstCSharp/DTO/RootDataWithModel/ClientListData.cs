using FirstCSharp.DTO.RootDataWithModel.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstCSharp.DTO.RootDataWithModel
{
    public class ClientListData : AbstractRootDataWithTotalCountAsString
    {
        [JsonPropertyName("client")]
        public required Client[] Clients { get; set; }
    }
}
