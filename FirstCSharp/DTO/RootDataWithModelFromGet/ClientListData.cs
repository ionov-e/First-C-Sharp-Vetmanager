using FirstCSharp.DTO.RootDataWithModel.Model;
using System.Text.Json.Serialization;

namespace FirstCSharp.DTO.RootDataWithModel
{
    internal class ClientListData : AbstractContainerWithModelsAndStringCount
    {
        [JsonPropertyName("client")]
        public required Client[] Models { get; set; }
        public override Client[] GetModels()
        {
            return Models;
        }
    }
}

