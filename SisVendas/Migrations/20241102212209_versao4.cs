using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SisVendas.Migrations
{
    /// <inheritdoc />
    public partial class versao4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Apelido = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    CpfCnpj = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.IdPessoa);
                });

            migrationBuilder.CreateTable(
                name: "contatoPessoas",
                columns: table => new
                {
                    IdContatoPessoa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DDDfone = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    Telefone = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    IdPessoa = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contatoPessoas", x => x.IdContatoPessoa);
                    table.ForeignKey(
                        name: "FK_contatoPessoas_Pessoas_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnderecoPessoas",
                columns: table => new
                {
                    IdEnderecoPessoa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cep = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    Endereco = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Numero = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Bairro = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Complemento = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    UF = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    IdPessoa = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoPessoas", x => x.IdEnderecoPessoa);
                    table.ForeignKey(
                        name: "FK_EnderecoPessoas_Pessoas_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contatoPessoas_IdPessoa",
                table: "contatoPessoas",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoPessoas_IdPessoa",
                table: "EnderecoPessoas",
                column: "IdPessoa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contatoPessoas");

            migrationBuilder.DropTable(
                name: "EnderecoPessoas");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
