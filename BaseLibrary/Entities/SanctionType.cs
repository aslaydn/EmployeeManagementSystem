using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class SanctionType : BaseEntity
    {
        //Vacation ile çoğun bire ilişkisi
        [JsonIgnore]
        public List<Sanction>? Sanctions { get; set; } 
    }
}
