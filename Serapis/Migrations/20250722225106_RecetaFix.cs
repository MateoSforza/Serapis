using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Serapis.Migrations
{
    /// <inheritdoc />
    public partial class RecetaFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Recetas_RecetaId",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Usuarios_UsuarioId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_RecetaId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_UsuarioId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "Anulada",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Ventas");

            migrationBuilder.RenameColumn(
                name: "Contenido",
                table: "Recetas",
                newName: "Detalle");

            migrationBuilder.AddColumn<string>(
                name: "Medico",
                table: "Recetas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VentaId",
                table: "Recetas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_RecetaId",
                table: "Ventas",
                column: "RecetaId",
                unique: true,
                filter: "[RecetaId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Recetas_RecetaId",
                table: "Ventas",
                column: "RecetaId",
                principalTable: "Recetas",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Recetas_RecetaId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_RecetaId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "Medico",
                table: "Recetas");

            migrationBuilder.DropColumn(
                name: "VentaId",
                table: "Recetas");

            migrationBuilder.RenameColumn(
                name: "Detalle",
                table: "Recetas",
                newName: "Contenido");

            migrationBuilder.AddColumn<bool>(
                name: "Anulada",
                table: "Ventas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Ventas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_RecetaId",
                table: "Ventas",
                column: "RecetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_UsuarioId",
                table: "Ventas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Recetas_RecetaId",
                table: "Ventas",
                column: "RecetaId",
                principalTable: "Recetas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Usuarios_UsuarioId",
                table: "Ventas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
