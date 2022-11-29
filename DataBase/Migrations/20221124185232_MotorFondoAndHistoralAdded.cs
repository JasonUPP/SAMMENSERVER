using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class MotorFondoAndHistoralAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MotorFondos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumSerie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorFondos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistorialMotorFondos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMotorFondo = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pozo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoOperacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Operador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfundidadMax = table.Column<int>(type: "int", nullable: false),
                    OD = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    MaxWHP = table.Column<int>(type: "int", nullable: false),
                    TemperaturaMaxima = table.Column<int>(type: "int", nullable: false),
                    MaxCircPressure = table.Column<int>(type: "int", nullable: false),
                    Diesel = table.Column<int>(type: "int", nullable: false),
                    Solvente = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Acido = table.Column<int>(type: "int", nullable: false),
                    Divergente = table.Column<int>(type: "int", nullable: false),
                    Nitrogeno = table.Column<int>(type: "int", nullable: false),
                    GelLineal = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Agua = table.Column<int>(type: "int", nullable: false),
                    HorasOperativas = table.Column<int>(type: "int", nullable: false),
                    HorasEfectivas = table.Column<int>(type: "int", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialMotorFondos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistorialMotorFondos_MotorFondos_IdMotorFondo",
                        column: x => x.IdMotorFondo,
                        principalTable: "MotorFondos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistorialMotorFondos_IdMotorFondo",
                table: "HistorialMotorFondos",
                column: "IdMotorFondo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistorialMotorFondos");

            migrationBuilder.DropTable(
                name: "MotorFondos");
        }
    }
}
