using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp.DTO
{
    public class Data<T>
    {
        public string totalCount { get; set; }
        public T[] client { get; set; }
    }
}
