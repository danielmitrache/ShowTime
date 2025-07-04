﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowTime.Migrations
{
    /// <inheritdoc />
    public partial class addedMNTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BandFestival");

            migrationBuilder.AddColumn<double>(
                name: "TicketPrice",
                table: "Festivals",
                type: "float",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FestivalBands",
                columns: table => new
                {
                    FestivalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: true),
                    Day = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FestivalBands", x => new { x.FestivalId, x.BandId });
                    table.ForeignKey(
                        name: "FK_FestivalBands_Bands_FestivalId",
                        column: x => x.FestivalId,
                        principalTable: "Bands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FestivalBands_Festivals_BandId",
                        column: x => x.BandId,
                        principalTable: "Festivals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FestivalBands_BandId",
                table: "FestivalBands",
                column: "BandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FestivalBands");

            migrationBuilder.DropColumn(
                name: "TicketPrice",
                table: "Festivals");

            migrationBuilder.CreateTable(
                name: "BandFestival",
                columns: table => new
                {
                    BandsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FestivalsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BandFestival", x => new { x.BandsId, x.FestivalsId });
                    table.ForeignKey(
                        name: "FK_BandFestival_Bands_BandsId",
                        column: x => x.BandsId,
                        principalTable: "Bands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BandFestival_Festivals_FestivalsId",
                        column: x => x.FestivalsId,
                        principalTable: "Festivals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BandFestival_FestivalsId",
                table: "BandFestival",
                column: "FestivalsId");
        }
    }
}
