using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updateOrderId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orderlines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orderlines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orderlines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Orderlines",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "OrderId", "PricelistId", "Quantity", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, 1, 3, 5, null, null, 1 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, 1, 2, 1, null, null, 1 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, 2, 2, 3, null, null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 30, 14, 37, 50, 502, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 30, 14, 37, 50, 502, DateTimeKind.Utc).AddTicks(9715));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orderlines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orderlines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orderlines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "Orderlines",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "OrderId", "PricelistId", "Quantity", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, 1, 3, 5, null, null, 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, 1, 2, 1, null, null, 1 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, 2, 2, 3, null, null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 30, 14, 33, 36, 411, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 30, 14, 33, 36, 411, DateTimeKind.Utc).AddTicks(7139));
        }
    }
}
