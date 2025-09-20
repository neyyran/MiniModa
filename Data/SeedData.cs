using BabyClothesShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BabyClothesShop.Data
{
    public class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            // 1️⃣ ROLLERİ EKLE
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roles = { "Admin", "User" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }

            // 2️⃣ KATEGORİ VE ÜRÜNLERİ EKLE
            var context = serviceProvider.GetRequiredService<AppDbContext>();
            await context.Database.MigrateAsync();

            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category { Name = "Kız Bebek & Çocuk", AgeGroup = "Yenidoğan" }, // 1
                    new Category { Name = "Kız Bebek & Çocuk", AgeGroup = "0-6 Ay" },     // 2
                    new Category { Name = "Kız Bebek & Çocuk", AgeGroup = "6-12 Ay" },    // 3
                    new Category { Name = "Kız Bebek & Çocuk", AgeGroup = "12-24 Ay" },   // 4
                    new Category { Name = "Erkek Bebek & Çocuk", AgeGroup = "Yenidoğan" },// 5
                    new Category { Name = "Erkek Bebek & Çocuk", AgeGroup = "0-6 Ay" },   // 6
                    new Category { Name = "Erkek Bebek & Çocuk", AgeGroup = "6-12 Ay" },  // 7
                    new Category { Name = "Erkek Bebek & Çocuk", AgeGroup = "12-24 Ay" }  // 8
                };

                await context.Categories.AddRangeAsync(categories);
                await context.SaveChangesAsync();
            }

            if (!context.Products.Any())
            {
                var products = new List<Product>
                {
                    // --- KIZ BEBEK ---
                    new Product { Name = "Çiçek Desenli Pembe Yenidoğan Kruvaze Takım", Price = 350.90m, ImageUrl = "https://i.ibb.co/HpC21JCg/yenidogan-kiz-bebek-zibin-seti-cicek-d-b5b6cd.jpg", CategoryId = 1 },
                    new Product { Name = "Çiçek Desenli Ekru Yenidoğan Kruvaze Takım", Price = 350.99m, ImageUrl = "https://i.ibb.co/3Ym00mc7/yenidogan-kiz-bebek-zibin-seti-cicek-d-2b-4cc.jpg", CategoryId = 1 },
                    new Product { Name = "Ay Baskılı Krem Yenidoğan Zıbın Kruvaze Takım", Price = 350.90m, ImageUrl = "https://i.ibb.co/HLb7B3vb/yenidogan-zibin-seti-ay-baskili-krem-y-d-97a7.jpg", CategoryId = 1 },
                    new Product { Name = "Zeytin Baskılı Yenidoğan Tulum", Price = 280.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/yenidogan-patikli-tulum-zeytin-baskili-30-b58.jpg", CategoryId = 1 },

                    new Product { Name = "%100 Pamuklu Papatya Desenli Yazlık Bebek Tulum", Price = 449.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/100-pamuk-papatya-desenli-yazlik-bebek--a3c3-.jpg", CategoryId = 2 },
                    new Product { Name = "Pembe Çiçekli Fırfırlı Kız Bebek Alt Üst Takım", Price = 279.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-takimi-pembe-cicekli-firfirl-f05-61.jpg", CategoryId = 2 },

                    new Product { Name = "Kız Bebek Şortlu Takım – Yazlık Tavşan Nakışlı İkili Takım", Price = 499.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-sortlu-takim-yazlik-tavsan-n-c18-48.jpg", CategoryId = 3 },
                    new Product { Name = "Papatya Baskılı Tişört ve Hardal Şortlu Yazlık Bebek Takımı – 2'li Penye Set", Price = 499.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/papatya-baskili-tisort-ve-hardal-sortl-f4e47d.jpg", CategoryId = 3 },
                    new Product { Name = "Pembe 3'lü Figürlü Kapüşonlu Hırkalı Kız Bebek Takımı", Price = 750.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-takimi-pembe-3lu-figurlu-kap-a17dae.jpg", CategoryId = 3 },

                    new Product { Name = "Kız Bebek Sweat Takım Kolu Fırfırlı Şardonlu", Price = 649.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-sweat-takim-kolu-firfirli-sa-357-00.jpg", CategoryId = 4 },
                    new Product { Name = "Turuncu Kız Bebek Sweat Takımı Şardonlu", Price = 649.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/turuncu-kiz-bebek-sweat-takimi-sardonl-6a-98c.jpg", CategoryId = 4 },
                    new Product { Name = "Kız Bebek Sweat Pantolon Takımı Pembe Bear Nakışlı", Price = 629.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-sweat-pantolon-takimi-pembe--cfe417.jpg", CategoryId = 4 },

                    // --- ERKEK BEBEK ---
                    new Product { Name = "Bebe Yaka 4'lü Yenidoğan Seti Erkek", Price = 750.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/bebe-yaka-4lu-yenidogan-seti-erkek-beb-d4-4a8.jpeg", CategoryId = 5 },
                    new Product { Name = "Krosatalı Bebe Yaka 4'lü Yenidoğan Seti Erkek", Price = 750.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/krosatali-bebe-yaka-4lu-yenidogan-seti-58d595.jpeg", CategoryId = 5 },
                    new Product { Name = "Fitilli Bebek Takımı Zeytin Baskılı Krem", Price = 350.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/fitilli-bebek-takimi-zeytin-baskili-kr-4-ebec.jpg", CategoryId = 5 },

                    new Product { Name = "Düz Mor Mevsimlik Bebek Takımı", Price = 299.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/dgz-gri-mevsimlik-bebek-takimi-alt-ust-6a78-4.jpg", CategoryId = 6 },
                    new Product { Name = "Mavi Yıldızlı Erkek Bebek Pijama Takımı", Price = 299.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/erkek-bebek-cocuk-pijama-takimi-0-6-ya-06a-98.jpg", CategoryId = 6 },

                    new Product { Name = "%100 Pamuk Denizci Temalı Erkek Bebek Yazlık Tulum", Price = 449.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/100-pamuk-denizci-temali-erkek-bebek-y-3c8289.jpg", CategoryId = 7 },
                    new Product { Name = "Bej Renk Bebek Yazlık Kısa Kollu Tulum", Price = 449.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/bej-renk-bebek-yazlik-kisa-kollu-tulum-5-9f4c.jpg", CategoryId = 7 },
                    new Product { Name = "Erkek Bebek Salopet Tişört Kaplan Desenli", Price = 449.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/erkek-bebek-salopet-tsihrt-kaplan-dese-5-470b.jpg", CategoryId = 7 },

                    new Product { Name = "Füme Kapüşonlu 3'lü Bebek Takımı", Price = 949.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/fume-kapusonlu-3lu-bebek-takimi-hirkal-177-8d.jpg", CategoryId = 8 },
                    new Product { Name = "Sweat Takım Şardonlu Kamyon Nakışlı Bebek Takımı", Price = 629.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/erkek-bebek-sweat-takim-sardonlu-kamyo-f1-46e.jpg", CategoryId = 8 },
                    new Product { Name = "Dino Mavi Şardonlu Çocuk Takım", Price = 629.90m, ImageUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/dino-mavi-sardonlu-cocuk-takim-2-6-yas-71cec2.jpg", CategoryId = 8 }
                };

                await context.Products.AddRangeAsync(products);
                await context.SaveChangesAsync();
            }
        }
    }
}
