using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace F1RacingSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "LastName", "TeamId" },
                values: new object[] { 4, "Fernando", "Alonso", null });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Monaco Grand Prix" },
                    { 2, "British Grand Prix" },
                    { 3, "Italian Grand Prix" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mercedes" },
                    { 2, "Red Bull" },
                    { 3, "Ferrari" }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "LastName", "TeamId" },
                values: new object[,]
                {
                    { 1, "Lewis", "Hamilton", 1 },
                    { 2, "Max", "Verstappen", 2 },
                    { 3, "Charles", "Leclerc", 3 }
                });

            migrationBuilder.InsertData(
                table: "DriverRaces",
                columns: new[] { "DriverId", "RaceId", "FinishedFor", "Points" },
                values: new object[,]
                {
                    { 1, 1, new TimeSpan(0, 1, 18, 0, 0), (byte)25 },
                    { 1, 2, new TimeSpan(0, 1, 40, 0, 0), (byte)25 },
                    { 1, 3, new TimeSpan(0, 2, 0, 0, 0), (byte)10 },
                    { 2, 1, new TimeSpan(0, 1, 19, 0, 0), (byte)18 },
                    { 2, 2, new TimeSpan(0, 1, 41, 0, 0), (byte)18 },
                    { 2, 3, new TimeSpan(0, 1, 58, 0, 0), (byte)15 },
                    { 3, 1, new TimeSpan(0, 1, 20, 0, 0), (byte)15 },
                    { 3, 2, new TimeSpan(0, 1, 42, 0, 0), (byte)12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
