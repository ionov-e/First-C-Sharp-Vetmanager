using System.Text.Json.Serialization;

namespace FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer
{
    internal class IdOnly : ModelContainerInterface
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
