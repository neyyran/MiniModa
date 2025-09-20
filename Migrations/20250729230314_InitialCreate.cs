using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 

namespace BabyClothesShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeGroup = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "AgeGroup", "Name" },
                values: new object[,]
                {
                    { 1, "Yenidoğan", "Kız Bebek & Çocuk" },
                    { 2, "0-6 Ay", "Kız Bebek & Çocuk" },
                    { 3, "6-12 Ay", "Kız Bebek & Çocuk" },
                    { 4, "12-24 Ay", "Kız Bebek & Çocuk" },
                    { 5, "Yenidoğan", "Erkek Bebek & Çocuk" },
                    { 6, "0-6 Ay", "Erkek Bebek & Çocuk" },
                    { 7, "6-12 Ay", "Erkek Bebek & Çocuk" },
                    { 8, "12-24 Ay", "Erkek Bebek & Çocuk" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, null, "https://i.ibb.co/HpC21JCg/yenidogan-kiz-bebek-zibin-seti-cicek-d-b5b6cd.jpg", "Çiçek Desenli Pembe Yenidoğan Kruvaze Takım", 350.90m },
                    { 2, 1, null, "https://i.ibb.co/3Ym00mc7/yenidogan-kiz-bebek-zibin-seti-cicek-d-2b-4cc.jpg", "Çiçek Desenli Ekru Yenidoğan Kruvaze Takım", 350.99m },
                    { 3, 1, null, "https://i.ibb.co/HLb7B3vb/yenidogan-zibin-seti-ay-baskili-krem-y-d-97a7.jpg", "Ay Baskılı Krem Yenidoğan Zıbın Kruvaze Takım", 350.90m },
                    { 4, 1, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/yenidogan-patikli-tulum-zeytin-baskili-30-b58.jpg", "Zeytin Baskılı Yenidoğan Tulum", 280.90m },
                    { 5, 2, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/100-pamuk-papatya-desenli-yazlik-bebek--a3c3-.jpg", "%100 Pamuklu Papatya Desenli Yazlık Bebek Tulum", 449.90m },
                    { 6, 2, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-takimi-pembe-cicekli-firfirl-f05-61.jpg", "Pembe Çiçekli Fırfırlı Kız Bebek Alt Üst Takım", 279.90m },
                    { 7, 3, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-sortlu-takim-yazlik-tavsan-n-c18-48.jpg", "Kız Bebek Şortlu Takım – Yazlık Tavşan Nakışlı İkili Takım", 499.90m },
                    { 8, 3, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/papatya-baskili-tisort-ve-hardal-sortl-f4e47d.jpg", "Papatya Baskılı Tişört ve Hardal Şortlu Yazlık Bebek Takımı – 2'li Penye Set", 499.90m },
                    { 9, 3, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-takimi-pembe-3lu-figurlu-kap-a17dae.jpg", "Pembe 3'lü Figürlü Kapüşonlu Hırkalı Kız Bebek Takımı", 750.90m },
                    { 10, 4, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-sweat-takim-kolu-firfirli-sa-357-00.jpg", "Kız Bebek Sweat Takım Kolu Fırfırlı Şardonlu", 649.90m },
                    { 11, 4, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/turuncu-kiz-bebek-sweat-takimi-sardonl-6a-98c.jpg", "Turuncu Kız Bebek Sweat Takımı Şardonlu", 649.90m },
                    { 12, 4, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/kiz-bebek-sweat-pantolon-takimi-pembe--cfe417.jpg", "Kız Bebek Sweat Pantolon Takımı Pembe Bear Nakışlı", 629.90m },
                    { 13, 5, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/bebe-yaka-4lu-yenidogan-seti-erkek-beb-d4-4a8.jpeg", "Bebe Yaka 4'lü Yenidoğan Seti Erkek", 750.90m },
                    { 14, 5, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/krosatali-bebe-yaka-4lu-yenidogan-seti-58d595.jpeg", "Krosatalı Bebe Yaka 4'lü Yenidoğan Seti Erkek", 750.90m },
                    { 15, 5, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/fitilli-bebek-takimi-zeytin-baskili-kr-4-ebec.jpg", "Fitilli Bebek Takımı Zeytin Baskılı Krem", 350.90m },
                    { 16, 6, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/dgz-gri-mevsimlik-bebek-takimi-alt-ust-6a78-4.jpg", "Düz Mor Mevsimlik Bebek Takımı", 299.90m },
                    { 17, 6, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/erkek-bebek-cocuk-pijama-takimi-0-6-ya-06a-98.jpg", "Mavi Yıldızlı Erkek Bebek Pijama Takımı", 299.90m },
                    { 18, 7, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/100-pamuk-denizci-temali-erkek-bebek-y-3c8289.jpg", "%100 Pamuk Denizci Temalı Erkek Bebek Yazlık Tulum", 449.90m },
                    { 19, 7, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/bej-renk-bebek-yazlik-kisa-kollu-tulum-5-9f4c.jpg", "Bej Renk Bebek Yazlık Kısa Kollu Tulum", 449.90m },
                    { 20, 7, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/erkek-bebek-salopet-tsihrt-kaplan-dese-5-470b.jpg", "Erkek Bebek Salopet Tişört Kaplan Desenli", 449.90m },
                    { 21, 8, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/fume-kapusonlu-3lu-bebek-takimi-hirkal-177-8d.jpg", "Füme Kapüşonlu 3'lü Bebek Takımı", 949.90m },
                    { 22, 8, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/erkek-bebek-sweat-takim-sardonlu-kamyo-f1-46e.jpg", "Sweat Takım Şardonlu Kamyon Nakışlı Bebek Takımı", 629.90m },
                    { 23, 8, null, "https://static.ticimax.cloud/cdn-cgi/image/width=568,quality=85/7179/uploads/urunresimleri/buyuk/dino-mavi-sardonlu-cocuk-takim-2-6-yas-71cec2.jpg", "Dino Mavi Şardonlu Çocuk Takım", 629.90m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
