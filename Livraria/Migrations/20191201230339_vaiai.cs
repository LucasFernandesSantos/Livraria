using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Migrations
{
    public partial class vaiai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DadosLivroId",
                table: "DevolucaoLivros",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservaLivroIdReservaLivro",
                table: "DevolucaoLivros",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusCliente",
                table: "Clientes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DevolucaoLivros_DadosLivroId",
                table: "DevolucaoLivros",
                column: "DadosLivroId");

            migrationBuilder.CreateIndex(
                name: "IX_DevolucaoLivros_ReservaLivroIdReservaLivro",
                table: "DevolucaoLivros",
                column: "ReservaLivroIdReservaLivro");

            migrationBuilder.AddForeignKey(
                name: "FK_DevolucaoLivros_DadosLivros_DadosLivroId",
                table: "DevolucaoLivros",
                column: "DadosLivroId",
                principalTable: "DadosLivros",
                principalColumn: "DadosLivroId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DevolucaoLivros_ReservaLivros_ReservaLivroIdReservaLivro",
                table: "DevolucaoLivros",
                column: "ReservaLivroIdReservaLivro",
                principalTable: "ReservaLivros",
                principalColumn: "IdReservaLivro",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevolucaoLivros_DadosLivros_DadosLivroId",
                table: "DevolucaoLivros");

            migrationBuilder.DropForeignKey(
                name: "FK_DevolucaoLivros_ReservaLivros_ReservaLivroIdReservaLivro",
                table: "DevolucaoLivros");

            migrationBuilder.DropIndex(
                name: "IX_DevolucaoLivros_DadosLivroId",
                table: "DevolucaoLivros");

            migrationBuilder.DropIndex(
                name: "IX_DevolucaoLivros_ReservaLivroIdReservaLivro",
                table: "DevolucaoLivros");

            migrationBuilder.DropColumn(
                name: "DadosLivroId",
                table: "DevolucaoLivros");

            migrationBuilder.DropColumn(
                name: "ReservaLivroIdReservaLivro",
                table: "DevolucaoLivros");

            migrationBuilder.DropColumn(
                name: "StatusCliente",
                table: "Clientes");
        }
    }
}
