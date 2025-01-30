using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace F1RacingSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Monaco Grand Prix" },
                    { 2, "British Grand Prix" },
                    { 3, "Italian Grand Prix" },
                    { 4, "German Grand Prix" },
                    { 5, "Spanish Grand Prix" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mercedes" },
                    { 2, "Red Bull" },
                    { 3, "Ferrari" },
                    { 4, "McLaren" },
                    { 5, "Aston Martin" },
                    { 6, "Alpine" },
                    { 7, "Alfa Romeo" },
                    { 8, "Haas" },
                    { 9, "Williams" }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "LastName", "TeamId" },
                values: new object[,]
                {
                    { 1, "Lewis", "Hamilton", 1 },
                    { 2, "Max", "Verstappen", 2 },
                    { 3, "Charles", "Leclerc", 3 },
                    { 4, "Fernando", "Alonso", 1 },
                    { 5, "Lando", "Norris", 4 },
                    { 6, "Sebastian", "Vettel", 5 },
                    { 7, "Esteban", "Ocon", 6 },
                    { 8, "Valtteri", "Bottas", 7 },
                    { 9, "Mick", "Schumacher", 8 },
                    { 10, "George", "Russell", 1 },
                    { 11, "Nicholas", "Latifi", 9 },
                    { 12, "Pierre", "Gasly", 6 }
                });

            migrationBuilder.InsertData(
                table: "DriverRaces",
                columns: new[] { "DriverId", "RaceId", "FinishedFor", "Points" },
                values: new object[,]
                {
                    { 1, 1, new TimeSpan(0, 1, 18, 0, 0), (short)25 },
                    { 1, 3, new TimeSpan(0, 1, 40, 0, 0), (short)25 },
                    { 2, 1, new TimeSpan(0, 1, 19, 0, 0), (short)18 },
                    { 2, 3, new TimeSpan(0, 1, 42, 0, 0), (short)18 },
                    { 3, 1, new TimeSpan(0, 1, 20, 0, 0), (short)15 },
                    { 3, 3, new TimeSpan(0, 1, 44, 0, 0), (short)15 },
                    { 4, 1, new TimeSpan(0, 1, 21, 0, 0), (short)12 },
                    { 4, 3, new TimeSpan(0, 1, 46, 0, 0), (short)12 },
                    { 5, 1, new TimeSpan(0, 1, 22, 0, 0), (short)10 },
                    { 6, 2, new TimeSpan(0, 1, 30, 0, 0), (short)18 },
                    { 7, 2, new TimeSpan(0, 1, 32, 0, 0), (short)15 },
                    { 8, 2, new TimeSpan(0, 1, 33, 0, 0), (short)10 },
                    { 9, 2, new TimeSpan(0, 1, 34, 0, 0), (short)8 },
                    { 10, 2, new TimeSpan(0, 1, 35, 0, 0), (short)6 }
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
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 2, 1 });

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
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5);

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
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 10);

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
                keyValue: 9);

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

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
