namespace BaseLibrary.Entities
{
    public class VacationType : BaseEntity
    {
        // Vacation ile çoğun bire ilişkisi
        public List<Vacation>? Vacations { get; set; }
    }
}
