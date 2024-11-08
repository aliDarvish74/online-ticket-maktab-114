namespace Model.Entities
{
    public class Province : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public int? ProvincePictureId { get; set; }
        public Blob? ProvincePicture { get; set; }
        public ICollection<City> Cities { get; set; } = new List<City>();
    }
}
