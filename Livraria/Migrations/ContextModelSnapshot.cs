﻿// <auto-generated />
using System;
using Livraria.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Livraria.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Livraria.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf");

                    b.Property<string>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<int?>("EnderecoId");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<string>("Telefone");

                    b.HasKey("ClienteId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Livraria.Models.DadosLivro", b =>
                {
                    b.Property<int>("DadosLivroId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor");

                    b.Property<string>("Description");

                    b.Property<int?>("GeneroId");

                    b.Property<string>("PublishedDate");

                    b.Property<string>("Publisher");

                    b.Property<int>("Quantidade");

                    b.Property<string>("Status");

                    b.Property<string>("Title");

                    b.Property<string>("Volume");

                    b.HasKey("DadosLivroId");

                    b.HasIndex("GeneroId");

                    b.ToTable("DadosLivros");
                });

            modelBuilder.Entity("Livraria.Models.DevolucaoLivro", b =>
                {
                    b.Property<int>("IdDevolucaoLivro")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId");

                    b.HasKey("IdDevolucaoLivro");

                    b.HasIndex("ClienteId");

                    b.ToTable("DevolucaoLivros");
                });

            modelBuilder.Entity("Livraria.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Uf");

                    b.Property<string>("endereco");

                    b.HasKey("EnderecoId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Livraria.Models.Genero", b =>
                {
                    b.Property<int>("GeneroId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("GeneroId");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("Livraria.Models.ReservaLivro", b =>
                {
                    b.Property<int>("IdReservaLivro")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("DataDevolucaoLivro");

                    b.Property<DateTime>("DataReservaLivro");

                    b.Property<int>("LivroId");

                    b.HasKey("IdReservaLivro");

                    b.HasIndex("ClienteId");

                    b.ToTable("ReservaLivros");
                });

            modelBuilder.Entity("Livraria.Models.Cliente", b =>
                {
                    b.HasOne("Livraria.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("Livraria.Models.DadosLivro", b =>
                {
                    b.HasOne("Livraria.Models.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId");
                });

            modelBuilder.Entity("Livraria.Models.DevolucaoLivro", b =>
                {
                    b.HasOne("Livraria.Models.Cliente", "Cliente")
                        .WithMany("DevolucaoLivro")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("Livraria.Models.ReservaLivro", b =>
                {
                    b.HasOne("Livraria.Models.Cliente", "Cliente")
                        .WithMany("ReservaLivro")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
