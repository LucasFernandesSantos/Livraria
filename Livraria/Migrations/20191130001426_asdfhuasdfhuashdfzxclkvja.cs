using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Migrations
{
    public partial class asdfhuasdfhuashdfzxclkvja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GeneroId",
                table: "DadosLivros",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DadosLivros_GeneroId",
                table: "DadosLivros",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_DadosLivros_Genero_GeneroId",
                table: "DadosLivros",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "GeneroId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DadosLivros_Genero_GeneroId",
                table: "DadosLivros");

            migrationBuilder.DropIndex(
                name: "IX_DadosLivros_GeneroId",
                table: "DadosLivros");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "DadosLivros");
        }
    }
}
