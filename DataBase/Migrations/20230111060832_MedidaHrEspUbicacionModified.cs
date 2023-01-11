using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class MedidaHrEspUbicacionModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "MedidaHerramientaEspecials");

            migrationBuilder.AddColumn<int>(
                name: "IdUbicacion",
                table: "MedidaHerramientaEspecials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MedidaHerramientaEspecials_IdUbicacion",
                table: "MedidaHerramientaEspecials",
                column: "IdUbicacion");

            migrationBuilder.AddForeignKey(
                name: "FK_MedidaHerramientaEspecials_Ubicaciones_IdUbicacion",
                table: "MedidaHerramientaEspecials",
                column: "IdUbicacion",
                principalTable: "Ubicaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedidaHerramientaEspecials_Ubicaciones_IdUbicacion",
                table: "MedidaHerramientaEspecials");

            migrationBuilder.DropIndex(
                name: "IX_MedidaHerramientaEspecials_IdUbicacion",
                table: "MedidaHerramientaEspecials");

            migrationBuilder.DropColumn(
                name: "IdUbicacion",
                table: "MedidaHerramientaEspecials");

            migrationBuilder.AddColumn<string>(
                name: "Ubicacion",
                table: "MedidaHerramientaEspecials",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
