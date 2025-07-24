namespace BaseLibrary.Entities
{
    public class Department : BaseEntity
    {
        //general department ile çoğun bire ilişkisi
        public GeneralDepartment? GeneralDepartment { get; set; }
        public int GeneralDepartmentId { get; set; }

        //branch ile birin çoğa ilişkisi
        public List<Branch>? Branches { get; set; }
    }
}
