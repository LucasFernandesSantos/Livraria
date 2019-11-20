using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Migrations
{
    public partial class teste12w : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Enderecos_EnderecoId",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "Clientes",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Cliente_EnderecoId",
                table: "Clientes",
                newName: "IX_Clientes_EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Enderecos_EnderecoId",
                table: "Clientes",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Enderecos_EnderecoId",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Cliente",
                newName: "IdCliente");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_EnderecoId",
                table: "Cliente",
                newName: "IX_Cliente_EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Enderecos_EnderecoId",
                table: "Cliente",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
