using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Migrations
{
    public partial class oitudobom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autores_VolumeInfo_VolumeInfoTitle",
                table: "Autores");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_VolumeInfo_volumeInfoTitle",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VolumeInfo",
                table: "VolumeInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autores",
                table: "Autores");

            migrationBuilder.RenameColumn(
                name: "volumeInfoTitle",
                table: "Items",
                newName: "volumeInfoIdTittle");

            migrationBuilder.RenameIndex(
                name: "IX_Items_volumeInfoTitle",
                table: "Items",
                newName: "IX_Items_volumeInfoIdTittle");

            migrationBuilder.RenameColumn(
                name: "VolumeInfoTitle",
                table: "Autores",
                newName: "VolumeInfoIdTittle");

            migrationBuilder.RenameIndex(
                name: "IX_Autores_VolumeInfoTitle",
                table: "Autores",
                newName: "IX_Autores_VolumeInfoIdTittle");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "VolumeInfo",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "IdTittle",
                table: "VolumeInfo",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "categories",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "IdCategories",
                table: "Categories",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Authors",
                table: "Autores",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "IdAuthors",
                table: "Autores",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VolumeInfo",
                table: "VolumeInfo",
                column: "IdTittle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "IdCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autores",
                table: "Autores",
                column: "IdAuthors");

            migrationBuilder.AddForeignKey(
                name: "FK_Autores_VolumeInfo_VolumeInfoIdTittle",
                table: "Autores",
                column: "VolumeInfoIdTittle",
                principalTable: "VolumeInfo",
                principalColumn: "IdTittle",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_VolumeInfo_volumeInfoIdTittle",
                table: "Items",
                column: "volumeInfoIdTittle",
                principalTable: "VolumeInfo",
                principalColumn: "IdTittle",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autores_VolumeInfo_VolumeInfoIdTittle",
                table: "Autores");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_VolumeInfo_volumeInfoIdTittle",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VolumeInfo",
                table: "VolumeInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autores",
                table: "Autores");

            migrationBuilder.DropColumn(
                name: "IdTittle",
                table: "VolumeInfo");

            migrationBuilder.DropColumn(
                name: "IdCategories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IdAuthors",
                table: "Autores");

            migrationBuilder.RenameColumn(
                name: "volumeInfoIdTittle",
                table: "Items",
                newName: "volumeInfoTitle");

            migrationBuilder.RenameIndex(
                name: "IX_Items_volumeInfoIdTittle",
                table: "Items",
                newName: "IX_Items_volumeInfoTitle");

            migrationBuilder.RenameColumn(
                name: "VolumeInfoIdTittle",
                table: "Autores",
                newName: "VolumeInfoTitle");

            migrationBuilder.RenameIndex(
                name: "IX_Autores_VolumeInfoIdTittle",
                table: "Autores",
                newName: "IX_Autores_VolumeInfoTitle");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "VolumeInfo",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "categories",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Authors",
                table: "Autores",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VolumeInfo",
                table: "VolumeInfo",
                column: "Title");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autores",
                table: "Autores",
                column: "Authors");

            migrationBuilder.AddForeignKey(
                name: "FK_Autores_VolumeInfo_VolumeInfoTitle",
                table: "Autores",
                column: "VolumeInfoTitle",
                principalTable: "VolumeInfo",
                principalColumn: "Title",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_VolumeInfo_volumeInfoTitle",
                table: "Items",
                column: "volumeInfoTitle",
                principalTable: "VolumeInfo",
                principalColumn: "Title",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
