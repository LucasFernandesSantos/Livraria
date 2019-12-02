using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Migrations
{
    public partial class testetesteteste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GeneroLivroId",
                table: "DadosLivros",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    GeneroLivroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.GeneroLivroId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DadosLivros_GeneroLivroId",
                table: "DadosLivros",
                column: "GeneroLivroId");

            migrationBuilder.AddForeignKey(
                name: "FK_DadosLivros_Generos_GeneroLivroId",
                table: "DadosLivros",
                column: "GeneroLivroId",
                principalTable: "Generos",
                principalColumn: "GeneroLivroId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DadosLivros_Generos_GeneroLivroId",
                table: "DadosLivros");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropIndex(
                name: "IX_DadosLivros_GeneroLivroId",
                table: "DadosLivros");

            migrationBuilder.DropColumn(
                name: "GeneroLivroId",
                table: "DadosLivros");
        }
    }
}
