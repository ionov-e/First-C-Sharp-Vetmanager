using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp.DTO.RootDataWithModel.Model
{
    public class Breed
    {
        public required string id { get; set; }
        public required string title { get; set; }
        public required string pet_type_id { get; set; }
        public override string ToString()
        {
            return title;
        }
    }
}
