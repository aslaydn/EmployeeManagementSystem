namespace BaseLibrary.Entities
{
    public class Town : BaseEntity
    {
        //employee ile birin çoğa ilişkisi 
        public List<Employee>? Employees { get; set; }

        //city ile çoğun bire ilişkisi
        public City? City { get; set; }
        public int CityId { get; set; }
    }
}
