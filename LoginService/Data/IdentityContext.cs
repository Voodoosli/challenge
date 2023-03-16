using LoginService.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginService.Data
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        public readonly IHttpContextAccessor httpContextAccessor;

        public IdentityContext(DbContextOptions<IdentityContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public DbSet<ApplicationUserTokens> ApplicationUserTokens { get; set; }
    }
    
}
