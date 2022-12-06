using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class AfterRequirementsFirstModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistorialMotorFondos");

            migrationBuilder.DropTable(
                name: "MotorFondos");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "BalinDesconector",
                table: "MedidaHerramientas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BalinSub",
                table: "MedidaHerramientas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "MedidaHerramientas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PresionMaxima",
                table: "MedidaHerramientas",
                type: "decimal(10,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "Acuse",
                table: "Herramientas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "IdMedidaHerramienta",
                table: "Herramientas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Herramientas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Modelo",
                table: "Herramientas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumeroSerie",
                table: "Herramientas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Observaciones",
                table: "Herramientas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Referencia = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IngenieroHerramientas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedidaHerramientaEspecials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoscaGIR = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    RoscaCaja = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    DiametroExterno = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    BalinPaso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitud = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    NumeroSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TensionMaxima = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroInforme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dias = table.Column<int>(type: "int", nullable: false),
                    Estatus = table.Column<int>(type: "int", nullable: false),
                    Acuse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Firma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiasEnCampo = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedidaHerramientaEspecials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroCelular = table.Column<int>(type: "int", nullable: false),
                    NSS = table.Column<int>(type: "int", nullable: false),
                    CursosAbordaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VigenciaCursosAbordaje = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CursosSSPA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VigenciaCursosSSPA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CursosTecnicos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VigenciaCursosTecnicos = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CVSAMMEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamenesMedicos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CursosOExperiencia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abreviatura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroCelular = table.Column<int>(type: "int", nullable: false),
                    CantidadUTF = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistorialHerramientas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pozo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoOperacion = table.Column<int>(type: "int", nullable: false),
                    Unidad = table.Column<int>(type: "int", nullable: false),
                    IdOperador = table.Column<int>(type: "int", nullable: false),
                    ProfundidadMax = table.Column<int>(type: "int", nullable: false),
                    OD = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    MaxWHP = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    TemperaturaMaxima = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    MaxCircPressure = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Diesel = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Solvente = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Acido = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Divergente = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Nitrogeno = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    GelLineal = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Agua = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    HorasOperativas = table.Column<int>(type: "int", nullable: false),
                    HorasEfectivas = table.Column<int>(type: "int", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialHerramientas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistorialHerramientas_Operadores_IdOperador",
                        column: x => x.IdOperador,
                        principalTable: "Operadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Herramientas_IdMedidaHerramienta",
                table: "Herramientas",
                column: "IdMedidaHerramienta");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialHerramientas_IdOperador",
                table: "HistorialHerramientas",
                column: "IdOperador");

            migrationBuilder.AddForeignKey(
                name: "FK_Herramientas_MedidaHerramientas_IdMedidaHerramienta",
                table: "Herramientas",
                column: "IdMedidaHerramienta",
                principalTable: "MedidaHerramientas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Herramientas_MedidaHerramientas_IdMedidaHerramienta",
                table: "Herramientas");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "HistorialHerramientas");

            migrationBuilder.DropTable(
                name: "MedidaHerramientaEspecials");

            migrationBuilder.DropTable(
                name: "Ubicaciones");

            migrationBuilder.DropTable(
                name: "Operadores");

            migrationBuilder.DropIndex(
                name: "IX_Herramientas_IdMedidaHerramienta",
                table: "Herramientas");

            migrationBuilder.DropColumn(
                name: "BalinDesconector",
                table: "MedidaHerramientas");

            migrationBuilder.DropColumn(
                name: "BalinSub",
                table: "MedidaHerramientas");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "MedidaHerramientas");

            migrationBuilder.DropColumn(
                name: "PresionMaxima",
                table: "MedidaHerramientas");

            migrationBuilder.DropColumn(
                name: "IdMedidaHerramienta",
                table: "Herramientas");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Herramientas");

            migrationBuilder.DropColumn(
                name: "Modelo",
                table: "Herramientas");

            migrationBuilder.DropColumn(
                name: "NumeroSerie",
                table: "Herramientas");

            migrationBuilder.DropColumn(
                name: "Observaciones",
                table: "Herramientas");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Acuse",
                table: "Herramientas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                    Acido = table.Column<int>(type: "int", nullable: false),
                    Agua = table.Column<int>(type: "int", nullable: false),
                    Diesel = table.Column<int>(type: "int", nullable: false),
                    Divergente = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GelLineal = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    HorasEfectivas = table.Column<int>(type: "int", nullable: false),
                    HorasOperativas = table.Column<int>(type: "int", nullable: false),
                    MaxCircPressure = table.Column<int>(type: "int", nullable: false),
                    MaxWHP = table.Column<int>(type: "int", nullable: false),
                    Nitrogeno = table.Column<int>(type: "int", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OD = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Operador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pozo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfundidadMax = table.Column<int>(type: "int", nullable: false),
                    Solvente = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    TemperaturaMaxima = table.Column<int>(type: "int", nullable: false),
                    TipoOperacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Unidad = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
    }
}
