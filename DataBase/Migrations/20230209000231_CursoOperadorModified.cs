using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class CursoOperadorModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CursosAbordaje",
                table: "Operadores");

            migrationBuilder.DropColumn(
                name: "VigenciaCursosAbordaje",
                table: "Operadores");

            migrationBuilder.DropColumn(
                name: "Vigencia",
                table: "Cursos");

            migrationBuilder.RenameColumn(
                name: "Referencia",
                table: "Cursos",
                newName: "Requerido");

            migrationBuilder.RenameColumn(
                name: "IngenieroHerramientas",
                table: "Cursos",
                newName: "Item");

            migrationBuilder.AddColumn<int>(
                name: "Estatus",
                table: "Operadores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estatus",
                table: "Operadores");

            migrationBuilder.RenameColumn(
                name: "Requerido",
                table: "Cursos",
                newName: "Referencia");

            migrationBuilder.RenameColumn(
                name: "Item",
                table: "Cursos",
                newName: "IngenieroHerramientas");

            migrationBuilder.AddColumn<string>(
                name: "CursosAbordaje",
                table: "Operadores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "VigenciaCursosAbordaje",
                table: "Operadores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Vigencia",
                table: "Cursos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
