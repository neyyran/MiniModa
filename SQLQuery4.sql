USE [BabyClothesDb];
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Id = 1)
    INSERT INTO dbo.Categories (Id, Name, AgeGroup)
    VALUES (1, N'Kız Bebek & Çocuk', N'Yenidoğan');

IF NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Id = 2)
    INSERT INTO dbo.Categories (Id, Name, AgeGroup)
    VALUES (2, N'Kız Bebek & Çocuk', N'0-6 Ay');

IF NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Id = 3)
    INSERT INTO dbo.Categories (Id, Name, AgeGroup)
    VALUES (3, N'Kız Bebek & Çocuk', N'6-12 Ay');

IF NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Id = 4)
    INSERT INTO dbo.Categories (Id, Name, AgeGroup)
    VALUES (4, N'Kız Bebek & Çocuk', N'12-24 Ay');

IF NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Id = 5)
    INSERT INTO dbo.Categories (Id, Name, AgeGroup)
    VALUES (5, N'Erkek Bebek & Çocuk', N'Yenidoğan');

IF NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Id = 6)
    INSERT INTO dbo.Categories (Id, Name, AgeGroup)
    VALUES (6, N'Erkek Bebek & Çocuk', N'0-6 Ay');

IF NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Id = 7)
    INSERT INTO dbo.Categories (Id, Name, AgeGroup)
    VALUES (7, N'Erkek Bebek & Çocuk', N'6-12 Ay');

IF NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Id = 8)
    INSERT INTO dbo.Categories (Id, Name, AgeGroup)
    VALUES (8, N'Erkek Bebek & Çocuk', N'12-24 Ay');


-- ---------- ÜRÜNLER ----------
IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 1)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (1, N'Çiçek Desenli Pembe Yenidoğan Kruvaze Takım', NULL, 350.90, N'https://i.ibb.co/HpC21JCg/yenidogan-kiz-bebek-zibin-seti-cicek-d-b5b6cd.jpg', 1);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 2)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (2, N'Çiçek Desenli Ekru Yenidoğan Kruvaze Takım', NULL, 350.99, N'https://i.ibb.co/3Ym00mc7/yenidogan-kiz-bebek-zibin-seti-cicek-d-2b-4cc.jpg', 1);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 3)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (3, N'Ay Baskılı Krem Yenidoğan Zıbın Kruvaze Takım', NULL, 350.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=-,quality=85/7179/uploads/urunresimleri/buyuk/yenidogan-zibin-seti-ay-baskili-krem-y-d-97a7.jpg', 1);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 4)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (4, N'Zeytin Baskılı Yenidoğan Tulum', NULL, 280.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/yenidogan-patikli-tulum-zeytin-baskili-30-b58.jpg', 1);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 5)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (5, N'%100 Pamuklu Papatya Desenli Yazlık Bebek Tulum', NULL, 449.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/100-pamuk-papatya-desenli-yazlik-bebek--a3c3-.jpg', 2);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 6)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (6, N'Pembe Çiçekli Fırfırlı Kız Bebek Alt Üst Takım', NULL, 279.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-takimi-pembe-cicekli-firfirl-f05-61.jpg', 2);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 7)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (7, N'Kız Bebek Şortlu Takım – Yazlık Tavşan Nakışlı İkili Takım', NULL, 499.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-sortlu-takim-yazlik-tavsan-n-c18-48.jpg', 3);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 8)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (8, N'Papatya Baskılı Tişört ve Hardal Şortlu Yazlık Bebek Takımı – 2''li Penye Set', NULL, 499.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/papatya-baskili-tisort-ve-hardal-sortl-f4e47d.jpg', 3);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 9)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (9, N'Pembe 3''lü Figürlü Kapüşonlu Hırkalı Kız Bebek Takımı', NULL, 750.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-takimi-pembe-3lu-figurlu-kap-a17dae.jpg', 3);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 10)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (10, N'Kız Bebek Sweat Takım Kolu Fırfırlı Şardonlu', NULL, 649.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-sweat-takim-kolu-firfirli-sa-357-00.jpg', 4);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 11)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (11, N'Turuncu Kız Bebek Sweat Takımı Şardonlu', NULL, 649.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/turuncu-kiz-bebek-sweat-takimi-sardonl-6a-98c.jpg', 4);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 12)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (12, N'Kız Bebek Sweat Pantolon Takımı Pembe Bear Nakışlı', NULL, 629.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-sweat-pantolon-takimi-pembe--cfe417.jpg', 4);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 13)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (13, N'Bebe Yaka 4''lü Yenidoğan Seti Erkek', NULL, 750.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/bebe-yaka-4lu-yenidogan-seti-erkek-beb-d4-4a8.jpeg', 5);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 14)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (14, N'Krosatalı Bebe Yaka 4''lü Yenidoğan Seti Erkek', NULL, 750.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/krosatali-bebe-yaka-4lu-yenidogan-seti-58d595.jpeg', 5);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 15)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (15, N'Fitilli Bebek Takımı Zeytin Baskılı Krem', NULL, 350.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/fitilli-bebek-takimi-zeytin-baskili-kr-4-ebec.jpg', 5);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 16)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (16, N'Düz Mor Mevsimlik Bebek Takımı', NULL, 299.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/dgz-gri-mevsimlik-bebek-takimi-alt-ust-6a78-4.jpg', 6);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 17)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (17, N'Mavi Yıldızlı Erkek Bebek Pijama Takımı', NULL, 299.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/erkek-bebek-cocuk-pijama-takimi-0-6-ya-06a-98.jpg', 6);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 18)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (18, N'%100 Pamuk Denizci Temalı Erkek Bebek Yazlık Tulum', NULL, 449.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/100-pamuk-denizci-temali-erkek-bebek-y-3c8289.jpg', 7);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 19)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (19, N'Bej Renk Bebek Yazlık Kısa Kollu Tulum', NULL, 449.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/bej-renk-bebek-yazlik-kisa-kollu-tulum-5-9f4c.jpg', 7);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 20)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (20, N'Erkek Bebek Salopet Tişört Kaplan Desenli', NULL, 449.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/erkek-bebek-salopet-tsihrt-kaplan-dese-5-470b.jpg', 7);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 21)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (21, N'Füme Kapüşonlu 3''lü Bebek Takımı', NULL, 949.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/fume-kapusonlu-3lu-bebek-takimi-hirkal-177-8d.jpg', 8);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 22)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (22, N'Sweat Takım Şardonlu Kamyon Nakışlı Bebek Takımı', NULL, 629.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/erkek-bebek-sweat-takim-sardonlu-kamyo-f1-46e.jpg', 8);

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE Id = 23)
    INSERT INTO dbo.Products (Id, Name, Description, Price, ImageUrl, CategoryId)
    VALUES (23, N'Dino Mavi Şardonlu Çocuk Takım', NULL, 629.90, N'https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/dino-mavi-sardonlu-cocuk-takim-2-6-yas-71cec2.jpg', 8);

    -- Veritabanındaki kategori sayısını kontrol et
SELECT COUNT(*) AS CategoryCount FROM dbo.Categories;

-- Veritabanındaki ürün sayısını kontrol et
SELECT COUNT(*) AS ProductCount  FROM dbo.Products;

-- İlk 5 ürünü listele
SELECT TOP (5) Id, Name, Price, CategoryId
FROM dbo.Products
ORDER BY Id;
