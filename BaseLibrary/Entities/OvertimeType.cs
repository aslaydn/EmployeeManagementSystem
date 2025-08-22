using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class OvertimeType : BaseEntity
    {
        //Overtime ile çoğun bire ilişkisi
        [JsonIgnore]
        public List<Overtime>? Overtimes { get; set; }
    }
}
