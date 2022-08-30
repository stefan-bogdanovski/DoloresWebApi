using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddRelationOrdersToOrderlines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orderlines",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Orderlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Orderlines",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "OrderId", "PricelistId", "Quantity", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, 2, 2, 3, null, null, 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 30, 14, 26, 46, 799, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 30, 14, 26, 46, 799, DateTimeKind.Utc).AddTicks(4335));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orderlines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Orderlines",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orderlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 30, 14, 16, 43, 643, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 30, 14, 16, 43, 643, DateTimeKind.Utc).AddTicks(9883));
        }
    }
}
