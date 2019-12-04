using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Migrations
{
    public partial class eoqal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StatusR",
                table: "ReservaLivros",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusR",
                table: "ReservaLivros");
        }
    }
}
