using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp.DTO
{
    public class PetType
    {
        public required string id { get; set; }
        public required string title { get; set; }
        public required string picture { get; set; }
        public string? type { get; set; }

        public override string ToString()
        {
            return title;
        }
    }
}
