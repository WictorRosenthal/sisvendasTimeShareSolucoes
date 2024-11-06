using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisVendas.Migrations
{
    /// <inheritdoc />
    public partial class versao3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_IdCategoria",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_UnidadeDeMedidas_IdUnidadeDeMedida",
                table: "Produtos");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_IdCategoria",
                table: "Produtos",
                column: "IdCategoria",
                principalTable: "Categorias",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_UnidadeDeMedidas_IdUnidadeDeMedida",
                table: "Produtos",
                column: "IdUnidadeDeMedida",
                principalTable: "UnidadeDeMedidas",
                principalColumn: "IdUnidadeDeMedida",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_IdCategoria",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_UnidadeDeMedidas_IdUnidadeDeMedida",
                table: "Produtos");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_IdCategoria",
                table: "Produtos",
                column: "IdCategoria",
                principalTable: "Categorias",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_UnidadeDeMedidas_IdUnidadeDeMedida",
                table: "Produtos",
                column: "IdUnidadeDeMedida",
                principalTable: "UnidadeDeMedidas",
                principalColumn: "IdUnidadeDeMedida",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
