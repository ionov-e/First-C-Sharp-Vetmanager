using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FirstCSharp.DTO.Client;

namespace FirstCSharp.DTO
{
    public class ApiResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public Data<Client> data { get; set; }
    }
}
