using System.Text.Json.Serialization;

namespace FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model
{
    public abstract class AbstractModel
    {
        public required string id { get; set; }
        [JsonIgnore]
        public int Id
        {
            get { return int.Parse(id); }
            set { id = value.ToString(); }
        }
    }
}
