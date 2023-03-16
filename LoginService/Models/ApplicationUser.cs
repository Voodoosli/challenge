using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LoginService.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [DisplayName("Full Name")]
        [StringLength(60)]
        public string FullName { get; set; }
    }
}
