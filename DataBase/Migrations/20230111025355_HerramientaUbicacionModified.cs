using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class HerramientaUbicacionModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Herramientas");

            migrationBuilder.AddColumn<int>(
                name: "IdUbicacion",
                table: "Herramientas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Herramientas_IdUbicacion",
                table: "Herramientas",
                column: "IdUbicacion");

            migrationBuilder.AddForeignKey(
                name: "FK_Herramientas_Ubicaciones_IdUbicacion",
                table: "Herramientas",
                column: "IdUbicacion",
                principalTable: "Ubicaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Herramientas_Ubicaciones_IdUbicacion",
                table: "Herramientas");

            migrationBuilder.DropIndex(
                name: "IX_Herramientas_IdUbicacion",
                table: "Herramientas");

            migrationBuilder.DropColumn(
                name: "IdUbicacion",
                table: "Herramientas");

            migrationBuilder.AddColumn<string>(
                name: "Ubicacion",
                table: "Herramientas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
