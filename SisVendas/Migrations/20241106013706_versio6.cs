using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisVendas.Migrations
{
    /// <inheritdoc />
    public partial class versio6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "Produtos",
                newName: "QtdMinima");

     
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
  

            migrationBuilder.RenameColumn(
                name: "QtdMinima",
                table: "Produtos",
                newName: "Quantidade");
        }
    }
}
