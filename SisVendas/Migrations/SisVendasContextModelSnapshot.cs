﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SisVendas.Models;

#nullable disable

namespace SisVendas.Migrations
{
    [DbContext(typeof(SisVendasContext))]
    partial class SisVendasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SisVendas.Models.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdCategoria"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("SisVendas.Models.ContatoPessoa", b =>
                {
                    b.Property<int>("IdContatoPessoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdContatoPessoa"));

                    b.Property<string>("DDDfone")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("integer");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("IdContatoPessoa");

                    b.HasIndex("IdPessoa");

                    b.ToTable("contatoPessoas");
                });

            modelBuilder.Entity("SisVendas.Models.EnderecoPessoa", b =>
                {
                    b.Property<int>("IdEnderecoPessoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdEnderecoPessoa"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("integer");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)");

                    b.HasKey("IdEnderecoPessoa");

                    b.HasIndex("IdPessoa");

                    b.ToTable("EnderecoPessoas");
                });

            modelBuilder.Entity("SisVendas.Models.Pessoa", b =>
                {
                    b.Property<int>("IdPessoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdPessoa"));

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("IdPessoa");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("SisVendas.Models.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdProduto"));

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("integer");

                    b.Property<int>("IdUnidadeDeMedida")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Preco")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Quantidade")
                        .HasColumnType("text");

                    b.HasKey("IdProduto");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("IdUnidadeDeMedida");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("SisVendas.Models.UnidadeDeMedida", b =>
                {
                    b.Property<int>("IdUnidadeDeMedida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdUnidadeDeMedida"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdUnidadeDeMedida");

                    b.ToTable("UnidadeDeMedidas");
                });

            modelBuilder.Entity("SisVendas.Models.ContatoPessoa", b =>
                {
                    b.HasOne("SisVendas.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SisVendas.Models.EnderecoPessoa", b =>
                {
                    b.HasOne("SisVendas.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SisVendas.Models.Produto", b =>
                {
                    b.HasOne("SisVendas.Models.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SisVendas.Models.UnidadeDeMedida", "UnidadeDeMedida")
                        .WithMany()
                        .HasForeignKey("IdUnidadeDeMedida")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("UnidadeDeMedida");
                });

            modelBuilder.Entity("SisVendas.Models.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}