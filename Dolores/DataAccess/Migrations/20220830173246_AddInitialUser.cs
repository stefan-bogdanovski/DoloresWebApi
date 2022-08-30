using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddInitialUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 30, 17, 32, 44, 821, DateTimeKind.Utc).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 30, 17, 32, 44, 821, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DeletedAt", "DeletedBy", "Email", "FirstName", "IsActive", "LastName", "Password", "RoleId", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[] { 10, null, null, "marko123@gmail.com", "Marko", true, "Markovic", "marko123", 1, null, null, "markeza" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

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
    }
}
