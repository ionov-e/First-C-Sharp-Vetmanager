using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp.DTO
{

    public class AbstractDataWithTotalCountAsString : ModelDataInterface
    {
        public required string totalCount { get; set; }
        public int TotalNumber
        {
            get { return Int32.Parse(totalCount); }
            set { totalCount = value.ToString(); }
        }
    }
}
