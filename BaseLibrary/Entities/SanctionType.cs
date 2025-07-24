namespace BaseLibrary.Entities
{
    public class SanctionType : BaseEntity
    {
        //Vacation ile çoğun bire ilişkisi
        public List<Sanction>? Sanctions { get; set; } 
    }
}
