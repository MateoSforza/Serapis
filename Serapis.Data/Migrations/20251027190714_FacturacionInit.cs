using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Serapis.Migrations
{
    /// <inheritdoc />
    public partial class FacturacionInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Recetas_RecetaId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_RecetaId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "RecetaId",
                table: "Ventas");

            migrationBuilder.AlterColumn<int>(
                name: "VentaId",
                table: "Recetas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VentaId = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    PuntoVenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<long>(type: "bigint", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Iva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaeVencimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaEmision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    FacturaOrigenId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facturas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Facturas_Facturas_FacturaOrigenId",
                        column: x => x.FacturaOrigenId,
                        principalTable: "Facturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagosFactura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacturaId = table.Column<int>(type: "int", nullable: false),
                    Medio = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagosFactura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagosFactura_Facturas_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Facturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recetas_VentaId",
                table: "Recetas",
                column: "VentaId",
                unique: true,
                filter: "[VentaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ClienteId",
                table: "Facturas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_FacturaOrigenId",
                table: "Facturas",
                column: "FacturaOrigenId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_VentaId",
                table: "Facturas",
                column: "VentaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PagosFactura_FacturaId",
                table: "PagosFactura",
                column: "FacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recetas_Ventas_VentaId",
                table: "Recetas",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recetas_Ventas_VentaId",
                table: "Recetas");

            migrationBuilder.DropTable(
                name: "PagosFactura");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Recetas_VentaId",
                table: "Recetas");

            migrationBuilder.AddColumn<int>(
                name: "RecetaId",
                table: "Ventas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VentaId",
                table: "Recetas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
