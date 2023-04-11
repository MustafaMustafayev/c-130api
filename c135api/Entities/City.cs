namespace c135api.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class Citizen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pin { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public Citizen? Father { get; set; }
        public int? FatherId { get; set; }
        public Citizen? Mother { get; set; }
        public int? MotherId { get; set; }
    }
}
