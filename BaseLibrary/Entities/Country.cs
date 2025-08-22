using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class Country : BaseEntity
    {
        //City ile birin çoğa ilişkisi
        [JsonIgnore]
        public List<City>? Cities { get; set; }
    }
}
