using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoPadelBlazoirServer.Migrations
{
    /// <inheritdoc />
    public partial class IstruttoreDisponibile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Disponibile",
                table: "IstruttoriPadel",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponibile",
                table: "IstruttoriPadel");
        }
    }
}
