using Microsoft.EntityFrameworkCore.Migrations;

namespace SalihRecipes.data.Migrations
{
    public partial class changeTypeAuthorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorFoods_Authors_AuthorId",
                table: "AuthorFoods");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "Authors",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorId1",
                table: "AuthorFoods",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuthorFoods_AuthorId1",
                table: "AuthorFoods",
                column: "AuthorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorFoods_Authors_AuthorId1",
                table: "AuthorFoods",
                column: "AuthorId1",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorFoods_Authors_AuthorId1",
                table: "AuthorFoods");

            migrationBuilder.DropIndex(
                name: "IX_AuthorFoods_AuthorId1",
                table: "AuthorFoods");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "AuthorFoods");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Authors",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorFoods_Authors_AuthorId",
                table: "AuthorFoods",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
