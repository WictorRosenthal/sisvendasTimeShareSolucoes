using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisVendas.Migrations
{
    /// <inheritdoc />
    public partial class versao5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "Estoque",
                table: "Produtos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "Estoque",
                table: "Produtos");

           
        }
    }
}
