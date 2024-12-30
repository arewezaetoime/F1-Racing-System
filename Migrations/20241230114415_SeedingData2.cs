using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace F1RacingSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "FinishedFor", "Points" },
                values: new object[] { new TimeSpan(0, 1, 40, 0, 0), (byte)25 });

            migrationBuilder.UpdateData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "FinishedFor", "Points" },
                values: new object[] { new TimeSpan(0, 1, 42, 0, 0), (byte)18 });

            migrationBuilder.InsertData(
                table: "DriverRaces",
                columns: new[] { "DriverId", "RaceId", "FinishedFor", "Points" },
                values: new object[,]
                {
                    { 3, 3, new TimeSpan(0, 1, 44, 0, 0), (byte)15 },
                    { 4, 1, new TimeSpan(0, 1, 21, 0, 0), (byte)12 },
                    { 4, 3, new TimeSpan(0, 1, 46, 0, 0), (byte)12 }
                });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 4,
                column: "TeamId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "LastName", "TeamId" },
                values: new object[] { 10, "George", "Russell", 1 });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "German Grand Prix" },
                    { 5, "Spanish Grand Prix" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "McLaren" },
                    { 5, "Aston Martin" },
                    { 6, "Alpine" },
                    { 7, "Alfa Romeo" },
                    { 8, "Haas" },
                    { 9, "Williams" }
                });

            migrationBuilder.InsertData(
                table: "DriverRaces",
                columns: new[] { "DriverId", "RaceId", "FinishedFor", "Points" },
                values: new object[] { 10, 2, new TimeSpan(0, 1, 35, 0, 0), (byte)6 });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "LastName", "TeamId" },
                values: new object[,]
                {
                    { 5, "Lando", "Norris", 4 },
                    { 6, "Sebastian", "Vettel", 5 },
                    { 7, "Esteban", "Ocon", 6 },
                    { 8, "Valtteri", "Bottas", 7 },
                    { 9, "Mick", "Schumacher", 8 },
                    { 11, "Nicholas", "Latifi", 9 },
                    { 12, "Pierre", "Gasly", 6 }
                });

            migrationBuilder.InsertData(
                table: "DriverRaces",
                columns: new[] { "DriverId", "RaceId", "FinishedFor", "Points" },
                values: new object[,]
                {
                    { 5, 1, new TimeSpan(0, 1, 22, 0, 0), (byte)10 },
                    { 6, 2, new TimeSpan(0, 1, 30, 0, 0), (byte)18 },
                    { 7, 2, new TimeSpan(0, 1, 32, 0, 0), (byte)15 },
                    { 8, 2, new TimeSpan(0, 1, 33, 0, 0), (byte)10 },
                    { 9, 2, new TimeSpan(0, 1, 34, 0, 0), (byte)8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

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

            migrationBuilder.UpdateData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "FinishedFor", "Points" },
                values: new object[] { new TimeSpan(0, 2, 0, 0, 0), (byte)10 });

            migrationBuilder.UpdateData(
                table: "DriverRaces",
                keyColumns: new[] { "DriverId", "RaceId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "FinishedFor", "Points" },
                values: new object[] { new TimeSpan(0, 1, 58, 0, 0), (byte)15 });

            migrationBuilder.InsertData(
                table: "DriverRaces",
                columns: new[] { "DriverId", "RaceId", "FinishedFor", "Points" },
                values: new object[,]
                {
                    { 1, 2, new TimeSpan(0, 1, 40, 0, 0), (byte)25 },
                    { 2, 2, new TimeSpan(0, 1, 41, 0, 0), (byte)18 },
                    { 3, 2, new TimeSpan(0, 1, 42, 0, 0), (byte)12 }
                });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 4,
                column: "TeamId",
                value: null);
        }
    }
}
