﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Migrations
{
    public partial class livraria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    endereco = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecoId);
                });

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

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    EnderecoId = table.Column<int>(nullable: true),
                    StatusCliente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Clientes_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DadosLivros",
                columns: table => new
                {
                    DadosLivroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Autor = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    PublishedDate = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    GeneroLivroId = table.Column<int>(nullable: true),
                    Imagem = table.Column<string>(nullable: true),
                    Genero = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosLivros", x => x.DadosLivroId);
                    table.ForeignKey(
                        name: "FK_DadosLivros_Generos_GeneroLivroId",
                        column: x => x.GeneroLivroId,
                        principalTable: "Generos",
                        principalColumn: "GeneroLivroId",
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
                    DadosLivroId = table.Column<int>(nullable: true),
                    ClienteId = table.Column<int>(nullable: false),
                    LivroId = table.Column<int>(nullable: false),
                    StatusR = table.Column<string>(nullable: true)
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
                        name: "FK_ReservaLivros_DadosLivros_DadosLivroId",
                        column: x => x.DadosLivroId,
                        principalTable: "DadosLivros",
                        principalColumn: "DadosLivroId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DevolucaoLivros",
                columns: table => new
                {
                    IdDevolucaoLivro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: true),
                    DadosLivroId = table.Column<int>(nullable: true),
                    ReservaLivroIdReservaLivro = table.Column<int>(nullable: true)
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
                        name: "FK_DevolucaoLivros_DadosLivros_DadosLivroId",
                        column: x => x.DadosLivroId,
                        principalTable: "DadosLivros",
                        principalColumn: "DadosLivroId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DevolucaoLivros_ReservaLivros_ReservaLivroIdReservaLivro",
                        column: x => x.ReservaLivroIdReservaLivro,
                        principalTable: "ReservaLivros",
                        principalColumn: "IdReservaLivro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EnderecoId",
                table: "Clientes",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_DadosLivros_GeneroLivroId",
                table: "DadosLivros",
                column: "GeneroLivroId");

            migrationBuilder.CreateIndex(
                name: "IX_DevolucaoLivros_ClienteId",
                table: "DevolucaoLivros",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_DevolucaoLivros_DadosLivroId",
                table: "DevolucaoLivros",
                column: "DadosLivroId");

            migrationBuilder.CreateIndex(
                name: "IX_DevolucaoLivros_ReservaLivroIdReservaLivro",
                table: "DevolucaoLivros",
                column: "ReservaLivroIdReservaLivro");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaLivros_ClienteId",
                table: "ReservaLivros",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaLivros_DadosLivroId",
                table: "ReservaLivros",
                column: "DadosLivroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DevolucaoLivros");

            migrationBuilder.DropTable(
                name: "ReservaLivros");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "DadosLivros");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Generos");
        }
    }
}
