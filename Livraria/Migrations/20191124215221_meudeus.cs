using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Migrations
{
    public partial class meudeus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Enderecos",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Enderecos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
