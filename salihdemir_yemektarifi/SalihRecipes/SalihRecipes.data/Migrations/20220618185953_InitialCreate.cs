using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalihRecipes.data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorAbout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodPrice = table.Column<double>(type: "float", nullable: true),
                    FoodMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodRecipe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    IsHome = table.Column<bool>(type: "bit", nullable: false),
                    IsSlider = table.Column<bool>(type: "bit", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                });

            migrationBuilder.CreateTable(
                name: "AuthorFoods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorFoods", x => new { x.AuthorId, x.FoodId });
                    table.ForeignKey(
                        name: "FK_AuthorFoods_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false)
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
                values: new object[,]
                {
                    { 1, "unlumamuller.jpg", "Unlu Mamüller", "unlu-mamuller" },
                    { 2, "corbalar.jpg", "Çorbalar", "corba" },
                    { 3, "tatlilar.jpg", "Tatlılar", "tatlilar" },
                    { 4, "Etliyemekler.jpg", "Etli Yemekler", "etli-yemekler" },
                    { 5, "balık-yemek-kategori.jpg", "Balık Yemekleri", "balik-yemekleri" },
                    { 6, "asya-yemekleri.jpg", "Asya Yemekleri", "asya-yemekleri" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodImage", "FoodMaterial", "FoodName", "FoodPrice", "FoodRecipe", "IsApproved", "IsHome", "IsSlider", "Url" },
                values: new object[,]
                {
                    { 1, "zeytinli_pogaca-slider.jpg", "a,b,c", "Zeytinli Poğaca", 7.0, "zeytin,hamur", true, true, true, "zeytinli-pogaca" },
                    { 2, "ezogelin-corbasi-tarifi.jpg", "ezogelinnnnnnnn", "Ezogelin Çorbası", 20.0, "ezogelin corbası", true, true, true, "ezogelin-corbasi" },
                    { 3, "mercimek_corba.jpg", "mercimejjjjj", "Mercimek Çorbası", 12.0, "mercimekkkk", true, false, false, "mercimek-corbasi" },
                    { 4, "kuru-baklava.jpeg", "baklavassdas", "Kuru Baklava", 21.0, "baklavaaa", true, true, true, "kuru-baklava" },
                    { 5, "kasarlipogaca.jpg", "kaşarrrrr", "Kaşarlı Poğaça", 5.0, "kaşarlıııı", true, true, false, "kasarli-pogaca" },
                    { 6, "mantar-corba.jpg", "mantarrrrr", "Mantar Çorbası", 10.0, "mantarrrrrrr", true, false, false, "mantar-corbasi" },
                    { 7, "cag-kebabi.jpg", "et,domates,sebze", "Cağ Kebabı", 46.0, "cag kebabı", true, false, false, "cag-kebabi" },
                    { 8, "uskumru-pilaki.jpeg", "uskumruuuu", "Uskumru Pilaki", 47.0, "uskumru pilaki", true, false, false, "uskumru-pilaki" },
                    { 9, "firinda-cinekop.jpg", "çinekopp", "Fırında Çinekop", 36.0, "fırınada çinekop", true, false, false, "firinda-cinekop" },
                    { 10, "sütlac.jpg", "a,b,c", "Sütlaç", 21.0, "sütlacccsç", true, false, false, "sütlac" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 4, 7 },
                    { 5, 8 },
                    { 5, 9 },
                    { 3, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorFoods_FoodId",
                table: "AuthorFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategories_FoodId",
                table: "FoodCategories",
                column: "FoodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorFoods");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
