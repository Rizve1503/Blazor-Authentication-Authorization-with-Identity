using Microsoft.AspNetCore.Identity;

namespace BlazorAppWithAPI.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DateOnly? DOB { get; set; }
        public string? Name { get; set; }
    }

}
