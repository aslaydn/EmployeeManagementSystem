namespace BaseLibrary.Entities
{
    public class Country : BaseEntity
    {
        //City ile birin çoğa ilişkisi
        public List<City>? Cities { get; set; }
    }
}
