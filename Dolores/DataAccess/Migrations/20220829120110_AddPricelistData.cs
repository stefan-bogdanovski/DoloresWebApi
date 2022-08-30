using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddPricelistData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MoneyCurrencies",
                columns: new[] { "Id", "CreatedAt", "Currency", "DeletedAt", "DeletedBy", "IsActive", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "€", null, null, false, null, null });

            migrationBuilder.InsertData(
                table: "MoneyCurrencies",
                columns: new[] { "Id", "CreatedAt", "Currency", "DeletedAt", "DeletedBy", "IsActive", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$", null, null, false, null, null });

            migrationBuilder.InsertData(
                table: "Pricelists",
                columns: new[] { "Id", "CurrencyId", "Date", "DeletedAt", "DeletedBy", "DiscountInPercent", "PerfumeSizeId", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(3830), null, null, 1, 1, 128.5m, null, null },
                    { 40, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7522), null, null, 0, 40, 79.41m, null, null },
                    { 38, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7514), null, null, 6, 38, 156.58m, null, null },
                    { 37, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7509), null, null, 5, 37, 86.79m, null, null },
                    { 34, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7496), null, null, 1, 34, 205.91m, null, null },
                    { 33, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7489), null, null, 7, 33, 179.94m, null, null },
                    { 31, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7481), null, null, 5, 31, 147.41m, null, null },
                    { 29, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7473), null, null, 4, 29, 105.37m, null, null },
                    { 28, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7468), null, null, 1, 28, 119.12m, null, null },
                    { 27, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7464), null, null, 8, 27, 121.6m, null, null },
                    { 26, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7460), null, null, 0, 26, 137.5m, null, null },
                    { 24, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7451), null, null, 5, 24, 109.56m, null, null },
                    { 23, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7446), null, null, 6, 23, 91.48m, null, null },
                    { 22, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7424), null, null, 1, 22, 131.23m, null, null },
                    { 21, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7419), null, null, 2, 21, 148.35m, null, null },
                    { 17, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7399), null, null, 3, 17, 248.62m, null, null },
                    { 41, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7527), null, null, 3, 41, 236.57m, null, null },
                    { 42, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7531), null, null, 4, 42, 103.03m, null, null },
                    { 43, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7535), null, null, 0, 43, 133.88m, null, null },
                    { 45, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7544), null, null, 5, 45, 124.94m, null, null },
                    { 74, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7687), null, null, 4, 74, 80.85m, null, null },
                    { 73, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7683), null, null, 6, 73, 224.41m, null, null },
                    { 72, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7679), null, null, 6, 72, 187.79m, null, null },
                    { 71, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7674), null, null, 2, 71, 143.33m, null, null },
                    { 69, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7665), null, null, 5, 69, 195.39m, null, null },
                    { 68, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7661), null, null, 0, 68, 198.56m, null, null },
                    { 67, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7657), null, null, 6, 67, 201.92m, null, null },
                    { 13, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7380), null, null, 9, 13, 122.58m, null, null },
                    { 63, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7635), null, null, 6, 63, 102.98m, null, null },
                    { 59, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7603), null, null, 0, 59, 150.88m, null, null },
                    { 56, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7590), null, null, 1, 56, 140.29m, null, null },
                    { 54, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7582), null, null, 6, 54, 60.55m, null, null },
                    { 52, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7573), null, null, 5, 52, 130.76m, null, null },
                    { 49, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7561), null, null, 5, 49, 196.25m, null, null },
                    { 48, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7557), null, null, 6, 48, 167.39m, null, null },
                    { 47, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7552), null, null, 2, 47, 220.42m, null, null },
                    { 60, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7621), null, null, 3, 60, 90.24m, null, null },
                    { 12, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7375), null, null, 4, 12, 150.12m, null, null },
                    { 11, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7371), null, null, 3, 11, 243.58m, null, null },
                    { 10, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7365), null, null, 1, 10, 66.83m, null, null },
                    { 46, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7548), null, null, 8, 46, 59.51m, null, null },
                    { 44, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7539), null, null, 8, 44, 228.38m, null, null }
                });

            migrationBuilder.InsertData(
                table: "Pricelists",
                columns: new[] { "Id", "CurrencyId", "Date", "DeletedAt", "DeletedBy", "DiscountInPercent", "PerfumeSizeId", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 39, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7518), null, null, 6, 39, 229.42m, null, null },
                    { 36, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7505), null, null, 9, 36, 189.13m, null, null },
                    { 35, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7501), null, null, 9, 35, 201.17m, null, null },
                    { 32, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7485), null, null, 7, 32, 240.43m, null, null },
                    { 30, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7477), null, null, 1, 30, 168.07m, null, null },
                    { 50, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7565), null, null, 1, 50, 132.41m, null, null },
                    { 25, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7455), null, null, 6, 25, 116.56m, null, null },
                    { 19, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7411), null, null, 4, 19, 116.91m, null, null },
                    { 18, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7406), null, null, 3, 18, 189.48m, null, null },
                    { 16, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7394), null, null, 5, 16, 103.72m, null, null },
                    { 15, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7389), null, null, 3, 15, 182.7m, null, null },
                    { 14, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7384), null, null, 3, 14, 95.25m, null, null },
                    { 6, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7345), null, null, 8, 6, 173.76m, null, null },
                    { 2, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7242), null, null, 9, 2, 131.7m, null, null },
                    { 20, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7415), null, null, 7, 20, 101.94m, null, null },
                    { 76, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7696), null, null, 9, 76, 149.69m, null, null },
                    { 51, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7569), null, null, 1, 51, 134.66m, null, null },
                    { 55, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7586), null, null, 7, 55, 138.28m, null, null },
                    { 9, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7359), null, null, 9, 9, 215.36m, null, null },
                    { 8, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7354), null, null, 8, 8, 166.36m, null, null },
                    { 7, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7350), null, null, 5, 7, 210.59m, null, null },
                    { 5, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7336), null, null, 4, 5, 154.44m, null, null },
                    { 4, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7331), null, null, 3, 4, 102.81m, null, null },
                    { 3, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7324), null, null, 3, 3, 228.55m, null, null },
                    { 77, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7700), null, null, 3, 77, 175.12m, null, null },
                    { 53, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7578), null, null, 6, 53, 104.32m, null, null },
                    { 75, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7692), null, null, 6, 75, 159.05m, null, null },
                    { 66, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7652), null, null, 1, 66, 133.76m, null, null },
                    { 65, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7644), null, null, 8, 65, 182.72m, null, null },
                    { 64, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7639), null, null, 7, 64, 103.55m, null, null },
                    { 62, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7631), null, null, 5, 62, 115.74m, null, null },
                    { 61, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7626), null, null, 3, 61, 94.45m, null, null },
                    { 58, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7599), null, null, 8, 58, 209.95m, null, null },
                    { 57, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7594), null, null, 2, 57, 190.52m, null, null },
                    { 70, 1, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7670), null, null, 8, 70, 203.91m, null, null },
                    { 78, 2, new DateTime(2022, 8, 29, 12, 1, 8, 969, DateTimeKind.Utc).AddTicks(7704), null, null, 7, 78, 104.87m, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Pricelists",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "MoneyCurrencies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MoneyCurrencies",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
