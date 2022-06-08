using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalihRecipes.data.Migrations
{
    public partial class AddingContactTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodDescription",
                table: "Foods");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "FoodDescription",
                table: "Foods",
                type: "TEXT",
                nullable: true);
        }
    }
}
