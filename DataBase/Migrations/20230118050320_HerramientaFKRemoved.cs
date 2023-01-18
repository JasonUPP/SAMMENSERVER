using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class HerramientaFKRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Herramientas_MedidaHerramientas_IdMedidaHerramienta",
                table: "Herramientas");

            migrationBuilder.DropIndex(
                name: "IX_Herramientas_IdMedidaHerramienta",
                table: "Herramientas");

            migrationBuilder.DropColumn(
                name: "IdMedidaHerramienta",
                table: "Herramientas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMedidaHerramienta",
                table: "Herramientas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Herramientas_IdMedidaHerramienta",
                table: "Herramientas",
                column: "IdMedidaHerramienta");

            migrationBuilder.AddForeignKey(
                name: "FK_Herramientas_MedidaHerramientas_IdMedidaHerramienta",
                table: "Herramientas",
                column: "IdMedidaHerramienta",
                principalTable: "MedidaHerramientas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
