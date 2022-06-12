using Microsoft.EntityFrameworkCore.Migrations;

namespace SalihRecipes.data.Migrations
{
    public partial class AddAuthorImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorImage",
                table: "Authors",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorImage",
                table: "Authors");
        }
    }
}
