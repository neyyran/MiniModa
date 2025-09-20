using System.ComponentModel.DataAnnotations;

namespace BabyClothesShop.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
