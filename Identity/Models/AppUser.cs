using Microsoft.AspNetCore.Identity;

namespace Identity.Models
{
    /// <summary>
    /// We inherit some properties from the IdentityUser class:
    ///     - id, username, claims, email, phone number, password hash, roles, security stamp,...etc
    /// <br />
    /// We can define additional properties to our users if there is a need
    /// </summary>
    public class AppUser : IdentityUser
    {
    }
}
