using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Migrations
{
    public partial class descricao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "DadosLivros",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "DadosLivros",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "DadosLivros");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "DadosLivros");
        }
    }
}
