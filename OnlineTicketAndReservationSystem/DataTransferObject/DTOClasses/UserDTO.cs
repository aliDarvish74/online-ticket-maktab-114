using System.ComponentModel.DataAnnotations;

namespace DataTransferObject.DTOClasses
{
    public class UserDTO : BaseDTO<Guid>
    {
        [Required(ErrorMessage = "درج نام الزامی است")]
        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "درج نام خانوادگی الزامی است")]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "درج آدرس ایمیل الزامی است")]
        [Display(Name = "آدرس ایمیل")]
        [EmailAddress(ErrorMessage = "فرمت آدرس ایمیل وارد شده نامعتبر است")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "درج شماره موبایل الزامی است")]
        [Display(Name = "شماره موبایل")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "درج کلمه عبور الزامی است")]
        [StringLength(100, ErrorMessage = "رمز عبور باید حداقل 6 حرف باشد", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Required(ErrorMessage = "درج تکرار کلمه عبور الزامی است")]
        [DataType(DataType.Password)]
        [Display(Name = "تکرار کلمه عبور")]
        [Compare("Password", ErrorMessage = "کلمه عبور و تکرار آن باید یکی باشند")]
        public string ConfirmPassword { get; set; }

    }
}
