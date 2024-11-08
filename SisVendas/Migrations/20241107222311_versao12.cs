using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SisVendas.Migrations
{
    /// <inheritdoc />
    public partial class versao12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    IdVenda = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataVenda = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TotalVenda = table.Column<double>(type: "double precision", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    IdPessoa = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.IdVenda);
                    table.ForeignKey(
                        name: "FK_Venda_Pessoas_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItenVenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdVenda = table.Column<int>(type: "integer", nullable: false),
                    IdProduto = table.Column<int>(type: "integer", nullable: false),
                    Quantidade = table.Column<int>(type: "integer", nullable: false),
                    Subtotal = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItenVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItenVenda_Produtos_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produtos",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItenVenda_Venda_IdVenda",
                        column: x => x.IdVenda,
                        principalTable: "Venda",
                        principalColumn: "IdVenda",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItenVenda_IdProduto",
                table: "ItenVenda",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_ItenVenda_IdVenda",
                table: "ItenVenda",
                column: "IdVenda");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_IdPessoa",
                table: "Venda",
                column: "IdPessoa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItenVenda");

            migrationBuilder.DropTable(
                name: "Venda");

        }
    }
}
