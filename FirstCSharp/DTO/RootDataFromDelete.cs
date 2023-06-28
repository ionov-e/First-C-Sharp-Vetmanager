using FirstCSharp.DTO.RootDataWithModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FirstCSharp.DTO
{
    internal class RootDataFromDelete: ContainerInterface
    {
        public required string id { get; set; }
        [JsonIgnore]
        public int Id
        {
            get { return int.Parse(id); }
            set { id = value.ToString(); }
        }
        public int TotalNumber { get => 1; set => throw new NotImplementedException(); }
    }
}
