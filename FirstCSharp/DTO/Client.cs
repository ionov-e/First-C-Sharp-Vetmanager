using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FirstCSharp.DTO
{
    public class Client : DtoInterface
    {
        [JsonPropertyName("id")]
        public required string Id { get; set; }
        [JsonPropertyName("address")]
        public required string Address { get; set; }                                               
        [JsonPropertyName("home_phone")]
        public required string HomePhone { get; set; }                                            
        [JsonPropertyName("work_phone")]
        public required string WorkPhone { get; set; }                                            
        [JsonPropertyName("note")]
        public required string Note { get; set; }                                                  
        [JsonPropertyName("type_id")]
        public string? TypeId { get; set; }                                               
        [JsonPropertyName("how_find")]
        public string? HowFind { get; set; }                                              
        [JsonPropertyName("balance")]
        public required string Balance { get; set; }                                               
        [JsonPropertyName("email")]
        public required string Email { get; set; }                                                 
        [JsonPropertyName("city")]
        public required string CityName { get; set; }                                                  
        [JsonPropertyName("city_id")]
        public string? CityId { get; set; }                                               
        [JsonPropertyName("date_register")]
        public string? DateRegister { get; set; }                                         
        [JsonPropertyName("cell_phone")]
        public required string CellPhone { get; set; }                                            
        [JsonPropertyName("zip")]
        public required string Zip { get; set; }                                                   
        [JsonPropertyName("registration_index")]
        public required string RegistrationIndex { get; set; }                                    
        [JsonPropertyName("vip")]
        public required string Vip { get; set; }                                                   
        [JsonPropertyName("last_name")]
        public required string LastName { get; set; }                                             
        [JsonPropertyName("first_name")]
        public required string FirstName { get; set; }                                            
        [JsonPropertyName("middle_name")]
        public required string MiddleName { get; set; }                                           
        [JsonPropertyName("status")]
        public required string Status { get; set; }                                                
        [JsonPropertyName("discount")]
        public required string Discount { get; set; }                                              
        [JsonPropertyName("passport_series")]
        public required string PassportSeries { get; set; }                                       
        [JsonPropertyName("lab_number")]
        public required string LabNumber { get; set; }                                            
        [JsonPropertyName("street_id")]
        public string? StreetId { get; set; }                                             
        [JsonPropertyName("apartment")]
        public required string Appartment { get; set; }                                             
        [JsonPropertyName("unsubscribe")]
        public required string IsUnsubscribed { get; set; }                                           
        [JsonPropertyName("in_blacklist")]
        public required string IsInBlacklist { get; set; }                                          
        [JsonPropertyName("last_visit_date")]
        public string? LastVisitDate { get; set; }                                       
        [JsonPropertyName("number_of_journal")]
        public required string NumberOfJournal { get; set; }                                     
        [JsonPropertyName("phone_prefix")]
        public required string PhonePrefix { get; set; }
        [JsonPropertyName("city_data")]
        public City? City { get; set; }
        [JsonPropertyName("client_type_data")]
        public ClientType? ClientTypeData { get; set; }
        [JsonPropertyName("street_data")]
        public Street? Street { get; set; }
    }
}
