using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Paises.Migrations
{
    /// <inheritdoc />
    public partial class TablaPaisesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fechaedicion",
                table: "Pais",
                newName: "FechaEdicion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaEdicion",
                table: "Pais",
                newName: "Fechaedicion");
        }
    }
}
