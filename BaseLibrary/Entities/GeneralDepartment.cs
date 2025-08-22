using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class GeneralDepartment : BaseEntity
    {
        //Department ile birin çoğa ilişkisi
        [JsonIgnore]
        public List<Department>? Departments { get; set; }
    }
}
