using FirstCSharp.DTO.RootDataWithModel;
using System.Text.Json.Serialization;

namespace FirstCSharp.DTO
{
    internal class RootDataFromDelete : ContainerInterface
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
