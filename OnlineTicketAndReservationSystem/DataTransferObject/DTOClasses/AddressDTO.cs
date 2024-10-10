namespace DataTransferObject.DTOClasses
{
    public class AddressDTO : BaseDTO<Guid>
    {
        public string PostalCode { get; set; }
        public string AddressDescription { get; set; }
        public Guid CityId { get; set; }
        public CityDTO City { get; set; }
    }
}