using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Migrations
{
    public partial class lalala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Items_itemsId",
                table: "Livros");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropIndex(
                name: "IX_Livros_itemsId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "itemsId",
                table: "Livros");

            migrationBuilder.RenameColumn(
                name: "Logradouro",
                table: "Enderecos",
                newName: "endereco");

            migrationBuilder.RenameColumn(
                name: "Localidade",
                table: "Enderecos",
                newName: "Cidade");

            migrationBuilder.AddColumn<int>(
                name: "LivroIdLivro",
                table: "Items",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DevolucaoLivros",
                columns: table => new
                {
                    IdDevolucaoLivro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: true),
                    LivroIdLivro = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevolucaoLivros", x => x.IdDevolucaoLivro);
                    table.ForeignKey(
                        name: "FK_DevolucaoLivros_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DevolucaoLivros_Livros_LivroIdLivro",
                        column: x => x.LivroIdLivro,
                        principalTable: "Livros",
                        principalColumn: "IdLivro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReservaLivros",
                columns: table => new
                {
                    IdReservaLivro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataReservaLivro = table.Column<DateTime>(nullable: false),
                    DataDevolucaoLivro = table.Column<DateTime>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    LivroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservaLivros", x => x.IdReservaLivro);
                    table.ForeignKey(
                        name: "FK_ReservaLivros_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservaLivros_Livros_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livros",
                        principalColumn: "IdLivro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_LivroIdLivro",
                table: "Items",
                column: "LivroIdLivro");

            migrationBuilder.CreateIndex(
                name: "IX_DevolucaoLivros_ClienteId",
                table: "DevolucaoLivros",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_DevolucaoLivros_LivroIdLivro",
                table: "DevolucaoLivros",
                column: "LivroIdLivro");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaLivros_ClienteId",
                table: "ReservaLivros",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaLivros_LivroId",
                table: "ReservaLivros",
                column: "LivroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Livros_LivroIdLivro",
                table: "Items",
                column: "LivroIdLivro",
                principalTable: "Livros",
                principalColumn: "IdLivro",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Livros_LivroIdLivro",
                table: "Items");

            migrationBuilder.DropTable(
                name: "DevolucaoLivros");

            migrationBuilder.DropTable(
                name: "ReservaLivros");

            migrationBuilder.DropIndex(
                name: "IX_Items_LivroIdLivro",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "LivroIdLivro",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "endereco",
                table: "Enderecos",
                newName: "Logradouro");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Enderecos",
                newName: "Localidade");

            migrationBuilder.AddColumn<string>(
                name: "itemsId",
                table: "Livros",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    IdAuthors = table.Column<string>(nullable: false),
                    Authors = table.Column<string>(nullable: true),
                    VolumeInfoIdTittle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.IdAuthors);
                    table.ForeignKey(
                        name: "FK_Autores_VolumeInfo_VolumeInfoIdTittle",
                        column: x => x.VolumeInfoIdTittle,
                        principalTable: "VolumeInfo",
                        principalColumn: "IdTittle",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livros_itemsId",
                table: "Livros",
                column: "itemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Autores_VolumeInfoIdTittle",
                table: "Autores",
                column: "VolumeInfoIdTittle");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Items_itemsId",
                table: "Livros",
                column: "itemsId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
