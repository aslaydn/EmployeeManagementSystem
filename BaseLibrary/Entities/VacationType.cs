using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class VacationType : BaseEntity
    {
        // Vacation ile çoğun bire ilişkisi
        [JsonIgnore]
        public List<Vacation>? Vacations { get; set; }
    }
}
