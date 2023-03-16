using System.ComponentModel.DataAnnotations;

namespace LoginService.Models
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Email required")]        
        public string Email { get; set; }

        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
