using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        // birin çoğa ilişkisi
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }

    }
}
