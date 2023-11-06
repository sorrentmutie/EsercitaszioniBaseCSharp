using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoPadelBlazoirServer.Migrations
{
    /// <inheritdoc />
    public partial class Lezioni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lezioni",
                columns: table => new
                {
                    IdLezione = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataOraInizio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataOraFine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Campo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IstruttoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lezioni", x => x.IdLezione);
                    table.ForeignKey(
                        name: "FK_Lezioni_IstruttoriPadel_IstruttoreId",
                        column: x => x.IstruttoreId,
                        principalTable: "IstruttoriPadel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lezioni_IstruttoreId",
                table: "Lezioni",
                column: "IstruttoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lezioni");
        }
    }
}
