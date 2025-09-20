using BabyClothesShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiniModa.Models;

namespace BabyClothesShop.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // -------------------- CATEGORIES --------------------
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Kız Bebek & Çocuk", AgeGroup = "Yenidoğan" },
                new Category { Id = 2, Name = "Kız Bebek & Çocuk", AgeGroup = "0-6 Ay" },
                new Category { Id = 3, Name = "Kız Bebek & Çocuk", AgeGroup = "6-12 Ay" },
                new Category { Id = 4, Name = "Kız Bebek & Çocuk", AgeGroup = "12-24 Ay" },

                new Category { Id = 5, Name = "Erkek Bebek & Çocuk", AgeGroup = "Yenidoğan" },
                new Category { Id = 6, Name = "Erkek Bebek & Çocuk", AgeGroup = "0-6 Ay" },
                new Category { Id = 7, Name = "Erkek Bebek & Çocuk", AgeGroup = "6-12 Ay" },
                new Category { Id = 8, Name = "Erkek Bebek & Çocuk", AgeGroup = "12-24 Ay" }
            );

            // -------------------- PRODUCTS --------------------
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Çiçek Desenli Pembe Yenidoğan Kruvaze Takım", Price = 350.90m, ImageUrl = "https://i.ibb.co/HpC21JCg/yenidogan-kiz-bebek-zibin-seti-cicek-d-b5b6cd.jpg", CategoryId = 1 },
                new Product { Id = 2, Name = "Çiçek Desenli Ekru Yenidoğan Kruvaze Takım", Price = 350.99m, ImageUrl = "https://i.ibb.co/3Ym00mc7/yenidogan-kiz-bebek-zibin-seti-cicek-d-2b-4cc.jpg", CategoryId = 1 },
                new Product { Id = 3, Name = "Ay Baskılı Krem Yenidoğan Zıbın Kruvaze Takım", Price = 350.90m, ImageUrl = "https://i.ibb.co/HLb7B3vb/yenidogan-zibin-seti-ay-baskili-krem-y-d-97a7.jpg", CategoryId = 1 },
                new Product { Id = 4, Name = "Zeytin Baskılı Yenidoğan Tulum", Price = 280.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/yenidogan-patikli-tulum-zeytin-baskili-30-b58.jpg", CategoryId = 1 },
                new Product { Id = 5, Name = "%100 Pamuklu Papatya Desenli Yazlık Bebek Tulum", Price = 449.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/100-pamuk-papatya-desenli-yazlik-bebek--a3c3-.jpg", CategoryId = 2 },
                new Product { Id = 6, Name = "Pembe Çiçekli Fırfırlı Kız Bebek Alt Üst Takım", Price = 279.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-takimi-pembe-cicekli-firfirl-f05-61.jpg", CategoryId = 2 },
                new Product { Id = 7, Name = "Kız Bebek Şortlu Takım – Yazlık Tavşan Nakışlı İkili Takım", Price = 499.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-sortlu-takim-yazlik-tavsan-n-c18-48.jpg", CategoryId = 3 },
                new Product { Id = 8, Name = "Papatya Baskılı Tişört ve Hardal Şortlu Yazlık Bebek Takımı – 2'li Penye Set", Price = 499.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/papatya-baskili-tisort-ve-hardal-sortl-f4e47d.jpg", CategoryId = 3 },
                new Product { Id = 9, Name = "Pembe 3'lü Figürlü Kapüşonlu Hırkalı Kız Bebek Takımı", Price = 750.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-takimi-pembe-3lu-figurlu-kap-a17dae.jpg", CategoryId = 3 },
                new Product { Id = 10, Name = "Kız Bebek Sweat Takım Kolu Fırfırlı Şardonlu", Price = 649.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-sweat-takim-kolu-firfirli-sa-357-00.jpg", CategoryId = 4 },
                new Product { Id = 11, Name = "Turuncu Kız Bebek Sweat Takımı Şardonlu", Price = 649.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/turuncu-kiz-bebek-sweat-takimi-sardonl-6a-98c.jpg", CategoryId = 4 },
                new Product { Id = 12, Name = "Kız Bebek Sweat Pantolon Takımı Pembe Bear Nakışlı", Price = 629.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-sweat-pantolon-takimi-pembe--cfe417.jpg", CategoryId = 4 },
                new Product { Id = 13, Name = "Bebe Yaka 4'lü Yenidoğan Seti Erkek", Price = 750.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/bebe-yaka-4lu-yenidogan-seti-erkek-beb-d4-4a8.jpeg", CategoryId = 5 },
                new Product { Id = 14, Name = "Krosatalı Bebe Yaka 4'lü Yenidoğan Seti Erkek", Price = 750.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/krosatali-bebe-yaka-4lu-yenidogan-seti-58d595.jpeg", CategoryId = 5 },
                new Product { Id = 15, Name = "Fitilli Bebek Takımı Zeytin Baskılı Krem", Price = 350.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/fitilli-bebek-takimi-zeytin-baskili-kr-4-ebec.jpg", CategoryId = 5 },
                new Product { Id = 16, Name = "Düz Mor Mevsimlik Bebek Takımı", Price = 299.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/dgz-gri-mevsimlik-bebek-takimi-alt-ust-6a78-4.jpg", CategoryId = 6 },
                new Product { Id = 17, Name = "Mavi Yıldızlı Erkek Bebek Pijama Takımı", Price = 299.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/erkek-bebek-cocuk-pijama-takimi-0-6-ya-06a-98.jpg", CategoryId = 6 },
                new Product { Id = 18, Name = "%100 Pamuk Denizci Temalı Erkek Bebek Yazlık Tulum", Price = 449.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/100-pamuk-denizci-temali-erkek-bebek-y-3c8289.jpg", CategoryId = 7 },
                new Product { Id = 19, Name = "Bej Renk Bebek Yazlık Kısa Kollu Tulum", Price = 449.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/bej-renk-bebek-yazlik-kisa-kollu-tulum-5-9f4c.jpg", CategoryId = 7 },
                new Product { Id = 20, Name = "Erkek Bebek Salopet Tişört Kaplan Desenli", Price = 449.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/erkek-bebek-salopet-tsihrt-kaplan-dese-5-470b.jpg", CategoryId = 7 },
                new Product { Id = 21, Name = "Füme Kapüşonlu 3'lü Bebek Takımı", Price = 949.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/fume-kapusonlu-3lu-bebek-takimi-hirkal-177-8d.jpg", CategoryId = 8 },
                new Product { Id = 22, Name = "Sweat Takım Şardonlu Kamyon Nakışlı Bebek Takımı", Price = 629.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/erkek-bebek-sweat-takim-sardonlu-kamyo-f1-46e.jpg", CategoryId = 8 },
                new Product { Id = 23, Name = "Dino Mavi Şardonlu Çocuk Takım", Price = 629.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/dino-mavi-sardonlu-cocuk-takim-2-6-yas-71cec2.jpg", CategoryId = 8 }
            );
        }
    }
}
