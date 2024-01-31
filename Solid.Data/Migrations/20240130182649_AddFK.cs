using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flightsList_airplaneList_AirplaneId",
                table: "flightsList");

            migrationBuilder.DropForeignKey(
                name: "FK_passangersList_flightsList_FlightId",
                table: "passangersList");

            migrationBuilder.RenameColumn(
                name: "FlightId",
                table: "passangersList",
                newName: "FlightID");

            migrationBuilder.RenameIndex(
                name: "IX_passangersList_FlightId",
                table: "passangersList",
                newName: "IX_passangersList_FlightID");

            migrationBuilder.RenameColumn(
                name: "AirplaneId",
                table: "flightsList",
                newName: "AirplaneID");

            migrationBuilder.RenameIndex(
                name: "IX_flightsList_AirplaneId",
                table: "flightsList",
                newName: "IX_flightsList_AirplaneID");

            migrationBuilder.AddForeignKey(
                name: "FK_flightsList_airplaneList_AirplaneID",
                table: "flightsList",
                column: "AirplaneID",
                principalTable: "airplaneList",
                principalColumn: "AirplaneId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_passangersList_flightsList_FlightID",
                table: "passangersList",
                column: "FlightID",
                principalTable: "flightsList",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flightsList_airplaneList_AirplaneID",
                table: "flightsList");

            migrationBuilder.DropForeignKey(
                name: "FK_passangersList_flightsList_FlightID",
                table: "passangersList");

            migrationBuilder.RenameColumn(
                name: "FlightID",
                table: "passangersList",
                newName: "FlightId");

            migrationBuilder.RenameIndex(
                name: "IX_passangersList_FlightID",
                table: "passangersList",
                newName: "IX_passangersList_FlightId");

            migrationBuilder.RenameColumn(
                name: "AirplaneID",
                table: "flightsList",
                newName: "AirplaneId");

            migrationBuilder.RenameIndex(
                name: "IX_flightsList_AirplaneID",
                table: "flightsList",
                newName: "IX_flightsList_AirplaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_flightsList_airplaneList_AirplaneId",
                table: "flightsList",
                column: "AirplaneId",
                principalTable: "airplaneList",
                principalColumn: "AirplaneId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_passangersList_flightsList_FlightId",
                table: "passangersList",
                column: "FlightId",
                principalTable: "flightsList",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
