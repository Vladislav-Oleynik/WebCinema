using Microsoft.EntityFrameworkCore.Migrations;

namespace WebCinema.Migrations
{
    public partial class NameFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Decription",
                table: "Movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Decription",
                table: "Cinemas",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Movies",
                newName: "Decription");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cinemas",
                newName: "Decription");
        }
    }
}
