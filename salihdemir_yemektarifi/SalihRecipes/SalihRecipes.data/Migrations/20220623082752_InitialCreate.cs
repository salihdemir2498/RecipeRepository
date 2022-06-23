using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalihRecipes.data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryImage = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ContactUserName = table.Column<string>(type: "TEXT", nullable: true),
                    ContactMail = table.Column<string>(type: "TEXT", nullable: true),
                    ContactSubject = table.Column<string>(type: "TEXT", nullable: true),
                    ContactMessage = table.Column<string>(type: "TEXT", nullable: true),
                    ContactDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ContactStatus = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    FoodPrice = table.Column<double>(type: "REAL", nullable: true),
                    FoodMaterial = table.Column<string>(type: "TEXT", nullable: true),
                    FoodRecipe = table.Column<string>(type: "TEXT", nullable: true),
                    FoodImage = table.Column<string>(type: "TEXT", nullable: true),
                    IsApproved = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsSlider = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => new { x.CategoryId, x.FoodId });
                    table.ForeignKey(
                        name: "FK_FoodCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodCategories_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryImage", "CategoryName", "Url" },
                values: new object[] { 1, "unlumamuller.jpg", "Unlu Mamüller", "unlu-mamuller" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryImage", "CategoryName", "Url" },
                values: new object[] { 2, "corbalar.jpg", "Çorbalar", "corba" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryImage", "CategoryName", "Url" },
                values: new object[] { 3, "tatlilar.jpg", "Tatlılar", "tatlilar" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryImage", "CategoryName", "Url" },
                values: new object[] { 4, "Etliyemekler.jpg", "Etli Yemekler", "etli-yemekler" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryImage", "CategoryName", "Url" },
                values: new object[] { 5, "balık-yemek-kategori.jpg", "Balık Yemekleri", "balik-yemekleri" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryImage", "CategoryName", "Url" },
                values: new object[] { 6, "asya-yemekleri.jpg", "Asya Yemekleri", "asya-yemekleri" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodImage", "FoodMaterial", "FoodName", "FoodPrice", "FoodRecipe", "IsApproved", "IsHome", "IsSlider", "Url", "UserId" },
                values: new object[] { 1, "zeytinli_pogaca-slider.jpg", "a,b,c", "Zeytinli Poğaca", 7.0, "zeytin,hamur", true, true, true, "zeytinli-pogaca", null });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodImage", "FoodMaterial", "FoodName", "FoodPrice", "FoodRecipe", "IsApproved", "IsHome", "IsSlider", "Url", "UserId" },
                values: new object[] { 2, "ezogelin-corbasi-tarifi.jpg", "ezogelinnnnnnnn", "Ezogelin Çorbası", 20.0, "ezogelin corbası", true, true, true, "ezogelin-corbasi", null });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodImage", "FoodMaterial", "FoodName", "FoodPrice", "FoodRecipe", "IsApproved", "IsHome", "IsSlider", "Url", "UserId" },
                values: new object[] { 3, "mercimek_corba.jpg", "mercimejjjjj", "Mercimek Çorbası", 12.0, "mercimekkkk", true, false, false, "mercimek-corbasi", null });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodImage", "FoodMaterial", "FoodName", "FoodPrice", "FoodRecipe", "IsApproved", "IsHome", "IsSlider", "Url", "UserId" },
                values: new object[] { 4, "kuru-baklava.jpeg", "baklavassdas", "Kuru Baklava", 21.0, "baklavaaa", true, true, true, "kuru-baklava", null });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodImage", "FoodMaterial", "FoodName", "FoodPrice", "FoodRecipe", "IsApproved", "IsHome", "IsSlider", "Url", "UserId" },
                values: new object[] { 5, "kasarlipogaca.jpg", "kaşarrrrr", "Kaşarlı Poğaça", 5.0, "kaşarlıııı", true, true, false, "kasarli-pogaca", null });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodImage", "FoodMaterial", "FoodName", "FoodPrice", "FoodRecipe", "IsApproved", "IsHome", "IsSlider", "Url", "UserId" },
                values: new object[] { 6, "mantar-corba.jpg", "mantarrrrr", "Mantar Çorbası", 10.0, "mantarrrrrrr", true, false, false, "mantar-corbasi", null });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodImage", "FoodMaterial", "FoodName", "FoodPrice", "FoodRecipe", "IsApproved", "IsHome", "IsSlider", "Url", "UserId" },
                values: new object[] { 7, "cag-kebabi.jpg", "et,domates,sebze", "Cağ Kebabı", 46.0, "cag kebabı", true, false, false, "cag-kebabi", null });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodImage", "FoodMaterial", "FoodName", "FoodPrice", "FoodRecipe", "IsApproved", "IsHome", "IsSlider", "Url", "UserId" },
                values: new object[] { 8, "uskumru-pilaki.jpeg", "uskumruuuu", "Uskumru Pilaki", 47.0, "uskumru pilaki", true, false, false, "uskumru-pilaki", null });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodImage", "FoodMaterial", "FoodName", "FoodPrice", "FoodRecipe", "IsApproved", "IsHome", "IsSlider", "Url", "UserId" },
                values: new object[] { 9, "firinda-cinekop.jpg", "çinekopp", "Fırında Çinekop", 36.0, "fırınada çinekop", true, false, false, "firinda-cinekop", null });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodImage", "FoodMaterial", "FoodName", "FoodPrice", "FoodRecipe", "IsApproved", "IsHome", "IsSlider", "Url", "UserId" },
                values: new object[] { 10, "sütlac.jpg", "a,b,c", "Sütlaç", 21.0, "sütlacccsç", true, false, false, "sütlac", null });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[] { 3, 4 });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[] { 2, 6 });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[] { 4, 7 });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[] { 5, 8 });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[] { 5, 9 });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[] { 3, 10 });

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategories_FoodId",
                table: "FoodCategories",
                column: "FoodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
