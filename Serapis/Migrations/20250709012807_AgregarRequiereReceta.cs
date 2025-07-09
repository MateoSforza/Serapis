using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Serapis.Migrations
{
    /// <inheritdoc />
    public partial class AgregarRequiereReceta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "RequiereReceta",
                table: "Productos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequiereReceta",
                table: "Productos");
        }
    }
}
