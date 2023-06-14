using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp.DTO
{
    public class Client
    {
        public string id { get; set; }
        public string address { get; set; }
        public string home_phone { get; set; }
        public string work_phone { get; set; }
        public string note { get; set; }
        public string type_id { get; set; }
        public string how_find { get; set; }
        public string balance { get; set; }
        public string email { get; set; }
        public string city { get; set; }
        public string city_id { get; set; }
        public string date_register { get; set; }
        public string cell_phone { get; set; }
        public string zip { get; set; }
        public object registration_index { get; set; }
        public string vip { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string status { get; set; }
        public string discount { get; set; }
        public string passport_series { get; set; }
        public string lab_number { get; set; }
        public string street_id { get; set; }
        public string apartment { get; set; }
        public string unsubscribe { get; set; }
        public string in_blacklist { get; set; }
        public string last_visit_date { get; set; }
        public string number_of_journal { get; set; }
        public string phone_prefix { get; set; }
        public City city_data { get; set; }
        public ClientType client_type_data { get; set; }
        public Street street_data { get; set; }
    }
}
