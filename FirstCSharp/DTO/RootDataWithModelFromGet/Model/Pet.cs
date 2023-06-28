using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FirstCSharp.DTO.RootDataWithModel.Model
{
    public class Pet : AbstractModel
    {
        public string? owner_id { get; set; }
        public string? type_id { get; set; }
        public required string alias { get; set; }
        public string? sex { get; set; }
        public required string date_register { get; set; }
        public string? birthday { get; set; }
        public required string note { get; set; }
        public string? breed_id { get; set; }
        public string? old_id { get; set; }
        public string? color_id { get; set; }
        public string? deathnote { get; set; }
        public string? deathdate { get; set; }
        public required string chip_number { get; set; }
        public required string lab_number { get; set; }
        public required string status { get; set; }
        public string? picture { get; set; }
        public string? weight { get; set; }
        public required string edit_date { get; set; }
        public Client? owner { get; set; }
        public PetType? type { get; set; }
        public Breed? breed { get; set; }
        public Color? color { get; set; }
    }
}
