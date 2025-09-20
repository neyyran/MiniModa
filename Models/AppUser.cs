using Microsoft.AspNetCore.Identity;

namespace BabyClothesShop.Models
{
    public class AppUser : IdentityUser
    {
        public string? FullName { get; set; } //  ek alan
    }
}
