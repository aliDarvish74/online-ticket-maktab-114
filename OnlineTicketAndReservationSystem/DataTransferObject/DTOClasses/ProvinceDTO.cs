using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DataTransferObject.DTOClasses
{
    public class ProvinceDTO : BaseDTO<Guid>
    {
        [Required(ErrorMessage = "درج نام استان الزامی است")]
        [Display(Name = "نام استان")]
        public string Name { get; set; }
        [Display(Name = "تصویر استان")]
        public BlobDTO? Picture { get; set; }
        public IFormFile? ProvinceFile { get; set; }
        public List<CityDTO?> Cities { get; set; } = new List<CityDTO?>();
    }
}
