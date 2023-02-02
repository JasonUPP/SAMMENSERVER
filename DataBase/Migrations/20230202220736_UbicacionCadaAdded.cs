using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class UbicacionCadaAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Herramientas_Ubicaciones_IdUbicacion",
                table: "Herramientas");

            migrationBuilder.DropForeignKey(
                name: "FK_MedidaHerramientaEspecials_Ubicaciones_IdUbicacion",
                table: "MedidaHerramientaEspecials");

            migrationBuilder.DropIndex(
                name: "IX_MedidaHerramientaEspecials_IdUbicacion",
                table: "MedidaHerramientaEspecials");

            migrationBuilder.DropIndex(
                name: "IX_Herramientas_IdUbicacion",
                table: "Herramientas");

            migrationBuilder.AddColumn<string>(
                name: "Caja",
                table: "Ubicaciones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Caja",
                table: "Ubicaciones");

            migrationBuilder.CreateIndex(
                name: "IX_MedidaHerramientaEspecials_IdUbicacion",
                table: "MedidaHerramientaEspecials",
                column: "IdUbicacion");

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

            migrationBuilder.AddForeignKey(
                name: "FK_MedidaHerramientaEspecials_Ubicaciones_IdUbicacion",
                table: "MedidaHerramientaEspecials",
                column: "IdUbicacion",
                principalTable: "Ubicaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
