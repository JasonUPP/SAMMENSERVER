using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class FixesOnModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumeroCelular",
                table: "Operadores",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Estructura",
                table: "HistorialHerramientas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "HistorialHerramientas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Modelo",
                table: "HistorialHerramientas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumeroSerie",
                table: "HistorialHerramientas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estructura",
                table: "HistorialHerramientas");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "HistorialHerramientas");

            migrationBuilder.DropColumn(
                name: "Modelo",
                table: "HistorialHerramientas");

            migrationBuilder.DropColumn(
                name: "NumeroSerie",
                table: "HistorialHerramientas");

            migrationBuilder.AlterColumn<int>(
                name: "NumeroCelular",
                table: "Operadores",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
