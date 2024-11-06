﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisVendas.Migrations
{
    /// <inheritdoc />
    public partial class versao7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        { 

            migrationBuilder.AlterColumn<int>(
                name: "QtdMinima",
                table: "Produtos",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Preco",
                table: "Produtos",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<string>(
                name: "QtdMinima",
                table: "Produtos",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Preco",
                table: "Produtos",
                type: "text",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AddColumn<int>(
                name: "IdUnidadeDeMedida",
                table: "Produtos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

        }
    }
}
