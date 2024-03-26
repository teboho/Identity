using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.Models
{
    /// <summary>
    /// Inheriting abilities to manipulate the AppUser entity in the database using EntityFrameworkCore
    /// </summary>
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
        { }
    }
}
