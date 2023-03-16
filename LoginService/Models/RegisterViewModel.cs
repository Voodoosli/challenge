using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LoginService.Models
{
    public class RegisterViewModel
    {
        [Required]
        [DisplayName("First And Last Name")]
        [StringLength(60)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
