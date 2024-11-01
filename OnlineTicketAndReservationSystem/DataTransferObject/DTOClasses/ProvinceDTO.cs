using System.ComponentModel.DataAnnotations;

namespace DataTransferObject.DTOClasses
{
    public class ProvinceDTO : BaseDTO<Guid>
    {
        [Required(ErrorMessage = "درج نام استان الزامی است")]
        [Display(Name = "نام استان")]
        public string Name { get; set; }

        public List<CityDTO?> Cities { get; set; } = new List<CityDTO?>();
    }
}
