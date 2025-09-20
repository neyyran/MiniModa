using System.Text.Json.Serialization;

namespace BabyClothesShop.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;
        public string? Description { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = default!;

        public int CategoryId { get; set; }

        // Navigation property'nin istekte zorunlu olmaması için nullable yap
        // ve binding/validasyondan muaf etmek için JsonIgnore ekle
        [JsonIgnore]
        public Category? Category { get; set; }
    }
}

