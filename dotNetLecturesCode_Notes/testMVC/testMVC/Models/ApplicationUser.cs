using Microsoft.AspNetCore.Identity;

namespace testMVC.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? Address { get; set; }
    }
}
