﻿namespace BabyClothesShop.Models
{
    public class RegisterDtoOld
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; } // ✅ Eklendi
    }
}
