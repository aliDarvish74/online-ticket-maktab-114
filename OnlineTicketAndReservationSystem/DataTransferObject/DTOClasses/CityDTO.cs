using Shared.Enums;

namespace DataTransferObject.DTOClasses
{
    public class CityDTO : BaseDTO<Guid>
    {
        public Statuses Statuses { get; set; }
        public string CityName { get; set; }
        //public ProvinceDTO Province { get; set; }
        public Guid ProvinceId { get; set; }
    }
}
