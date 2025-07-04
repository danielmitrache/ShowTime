using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowTime.Migrations
{
    /// <inheritdoc />
    public partial class FixAgainMN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FestivalBands_Festivals_BandId",
                table: "FestivalBands");

            migrationBuilder.AddForeignKey(
                name: "FK_FestivalBands_Festivals_FestivalId",
                table: "FestivalBands",
                column: "FestivalId",
                principalTable: "Festivals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FestivalBands_Festivals_FestivalId",
                table: "FestivalBands");

            migrationBuilder.AddForeignKey(
                name: "FK_FestivalBands_Festivals_BandId",
                table: "FestivalBands",
                column: "BandId",
                principalTable: "Festivals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
