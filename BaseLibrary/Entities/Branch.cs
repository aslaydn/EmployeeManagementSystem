namespace BaseLibrary.Entities
{
    public class Branch : BaseEntity
    {
        //Department ile çoğun bire ilişkisi
        public Department? Department { get; set; }
        public int DepartmentId { get; set; }

        //Employee ile birin çoğa ilişkisi
        public List<Employee>? Employees { get; set; }
    }
}
