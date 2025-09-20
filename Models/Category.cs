using System.Collections.Generic;

namespace BabyClothesShop.Models
{
    public class Category
    {
        public int Id { get; set; }

        // 👧 "Kız Bebek & Çocuk", 👦 "Erkek Bebek & Çocuk"
        public string Name { get; set; }

        // 🍼 "Yenidoğan", "0-6 Ay", "6-12 Ay" gibi
        public string AgeGroup { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
