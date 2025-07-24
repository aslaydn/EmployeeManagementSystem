namespace BaseLibrary.Entities
{
    public class GeneralDepartment : BaseEntity
    {
        //Department ile birin çoğa ilişkisi
        public List<Department>? Departments { get; set; }
    }
}
