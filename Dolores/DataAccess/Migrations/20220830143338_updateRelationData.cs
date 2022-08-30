using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updateRelationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
