namespace Model.Entities
{
    public class City : BaseEntity<Guid>
    {
        public int CityStatusId { get; set; }
        public string Name { get; set; }
        public Province Province { get; set; }
        public Guid ProvinceId { get; set; }
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
