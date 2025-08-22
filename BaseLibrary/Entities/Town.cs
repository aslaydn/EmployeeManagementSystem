using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class Town : BaseEntity
    {
        //employee ile birin çoğa ilişkisi 
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }

        //city ile çoğun bire ilişkisi
        public City? City { get; set; }
        public int CityId { get; set; }
    }
}
