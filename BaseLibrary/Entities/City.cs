namespace BaseLibrary.Entities
{
    public class City : BaseEntity
    {
        //country ile çoğun bire ilişkisi
        public Country? Country { get; set; }
        public int CountryId { get; set; }

        //town ile birin çoğa ilişkisi
        public List<Town>? Towns { get; set; }
    }
}
