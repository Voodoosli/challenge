using LoginService.Data;
using LoginService.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService.Extensions
{
    public class Seed
    {
        public static async Task SeedData(IdentityContext context, UserManager<ApplicationUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var users = new List<ApplicationUser>
                {
                    new ApplicationUser
                    {
                        FullName = "User",
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = false,
                        LockoutEnabled = true,
                        AccessFailedCount = 20
                    },
                    new ApplicationUser
                    {
                        FullName = "User2",
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = false,
                        LockoutEnabled = true,
                        AccessFailedCount = 20
                    },
                };
                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "12345aA.");
                }
            }
        }
    }
}
