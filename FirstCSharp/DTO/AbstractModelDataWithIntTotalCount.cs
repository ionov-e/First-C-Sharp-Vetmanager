using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstCSharp.DTO
{
    public class AbstractModelDataWithIntTotalCount
    {
        [JsonPropertyName("totalCount")]
        public required string totalCount;

        // [JsonIgnore]
        // public required string totalCount;

        //[JsonPropertyName("totalCount")]
        // public required string TotalCount
        // {
        //     get {
        //         throw new Exception("WTF?");
        //         //return totalCount.ToString();
        //         return totalCount;

        //         //    //if (totalCount is int)
        //         //    //{
        //         //    //    return totalCount.ToString();
        //         //    //}
        //         //    //else
        //         //    //{
        //         //    //    return totalCount;
        //         //    //}

        //     }

        //     set {
        //         throw new Exception("Here's provided value for set method: " + value);
        //         //totalCount = Int32.Parse(value);
        //         if (value is int)
        //         {
        //             totalCount = value.ToString();
        //         }
        //         else if (value is string)
        //         {
        //             totalCount = value;
        //         }
        //         else
        //         {
        //             throw new Exception("Wrong type provided for totalCount");
        //         }
        //     }
        // }
    }
}
