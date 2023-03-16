using Microsoft.AspNetCore.Identity;
using System;

namespace LoginService.Models
{
    public class ApplicationUserTokens : IdentityUserToken<string>
    {
        public DateTime ExpireDate { get; set; }
    }
}
