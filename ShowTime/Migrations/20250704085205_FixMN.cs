using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowTime.Migrations
{
    /// <inheritdoc />
    public partial class FixMN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FestivalBands_Bands_FestivalId",
                table: "FestivalBands");

            migrationBuilder.AddForeignKey(
                name: "FK_FestivalBands_Bands_BandId",
                table: "FestivalBands",
                column: "BandId",
                principalTable: "Bands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FestivalBands_Bands_BandId",
                table: "FestivalBands");

            migrationBuilder.AddForeignKey(
                name: "FK_FestivalBands_Bands_FestivalId",
                table: "FestivalBands",
                column: "FestivalId",
                principalTable: "Bands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
