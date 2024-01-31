using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "airplaneList",
                columns: table => new
                {
                    AirplaneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumSeats = table.Column<int>(type: "int", nullable: false),
                    IsProper = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_airplaneList", x => x.AirplaneId);
                });

            migrationBuilder.CreateTable(
                name: "flightsList",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SourceLand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    TakeingOffTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AirplaneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flightsList", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_flightsList_airplaneList_AirplaneId",
                        column: x => x.AirplaneId,
                        principalTable: "airplaneList",
                        principalColumn: "AirplaneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "passangersList",
                columns: table => new
                {
                    IdPassanger = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passangersList", x => x.IdPassanger);
                    table.ForeignKey(
                        name: "FK_passangersList_flightsList_FlightId",
                        column: x => x.FlightId,
                        principalTable: "flightsList",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_flightsList_AirplaneId",
                table: "flightsList",
                column: "AirplaneId");

            migrationBuilder.CreateIndex(
                name: "IX_passangersList_FlightId",
                table: "passangersList",
                column: "FlightId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "passangersList");

            migrationBuilder.DropTable(
                name: "flightsList");

            migrationBuilder.DropTable(
                name: "airplaneList");
        }
    }
}
