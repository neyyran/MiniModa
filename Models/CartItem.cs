using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BabyClothesShop.Models;

namespace MiniModa.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        // Sepetteki ürünün Id'si
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        // Sepette kaç adet var
        public int Quantity { get; set; }

        // Ürünle ilişki
        public Product Product { get; set; }
    }
}
