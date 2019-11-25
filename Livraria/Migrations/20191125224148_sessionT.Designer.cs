﻿// <auto-generated />
using System;
using Livraria.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Livraria.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20191125224148_sessionT")]
    partial class sessionT
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Livraria.Models.Autores", b =>
                {
                    b.Property<string>("Authors")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("VolumeInfoTitle");

                    b.HasKey("Authors");

                    b.HasIndex("VolumeInfoTitle");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("Livraria.Models.Categories", b =>
                {
                    b.Property<string>("categories")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ItemsId");

                    b.HasKey("categories");

                    b.HasIndex("ItemsId");

                    b.ToTable("Categories");
                });

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

            modelBuilder.Entity("Livraria.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Localidade");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Uf");

                    b.HasKey("EnderecoId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Livraria.Models.Items", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvarageRating");

                    b.Property<int>("Quantidade");

                    b.Property<string>("Volume");

                    b.Property<string>("volumeInfoTitle");

                    b.HasKey("Id");

                    b.HasIndex("volumeInfoTitle");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Livraria.Models.Livro", b =>
                {
                    b.Property<int>("IdLivro")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PageCoutn");

                    b.Property<string>("itemsId");

                    b.HasKey("IdLivro");

                    b.HasIndex("itemsId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("Livraria.Models.VolumeInfo", b =>
                {
                    b.Property<string>("Title")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("PublishedDate");

                    b.Property<string>("Publisher");

                    b.HasKey("Title");

                    b.ToTable("VolumeInfo");
                });

            modelBuilder.Entity("Livraria.Models.Autores", b =>
                {
                    b.HasOne("Livraria.Models.VolumeInfo")
                        .WithMany("Authors")
                        .HasForeignKey("VolumeInfoTitle");
                });

            modelBuilder.Entity("Livraria.Models.Categories", b =>
                {
                    b.HasOne("Livraria.Models.Items")
                        .WithMany("categories")
                        .HasForeignKey("ItemsId");
                });

            modelBuilder.Entity("Livraria.Models.Cliente", b =>
                {
                    b.HasOne("Livraria.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("Livraria.Models.Items", b =>
                {
                    b.HasOne("Livraria.Models.VolumeInfo", "volumeInfo")
                        .WithMany()
                        .HasForeignKey("volumeInfoTitle");
                });

            modelBuilder.Entity("Livraria.Models.Livro", b =>
                {
                    b.HasOne("Livraria.Models.Items", "items")
                        .WithMany()
                        .HasForeignKey("itemsId");
                });
#pragma warning restore 612, 618
        }
    }
}
