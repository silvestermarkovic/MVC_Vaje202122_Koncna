using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Vaje202122_Priprava.Migrations
{
    public partial class Popravek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "opis",
                table: "Kategorije",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "url",
                table: "Kategorije",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "opis",
                table: "Kategorije");

            migrationBuilder.DropColumn(
                name: "url",
                table: "Kategorije");
        }
    }
}
