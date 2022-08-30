using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddEntityForOrderline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Orderlines",
                table: "Orderlines");

            migrationBuilder.DeleteData(
                table: "Orderlines",
                keyColumns: new[] { "PricelistId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Orderlines",
                keyColumns: new[] { "PricelistId", "UserId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Orderlines",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Orderlines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Orderlines",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Orderlines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Orderlines",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orderlines",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Orderlines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orderlines",
                table: "Orderlines",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Orderlines",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "OrderId", "PricelistId", "Quantity", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, null, 3, 5, null, null, 1 });

            migrationBuilder.InsertData(
                table: "Orderlines",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "OrderId", "PricelistId", "Quantity", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, null, 2, 1, null, null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Orderlines_UserId",
                table: "Orderlines",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Orderlines",
                table: "Orderlines");

            migrationBuilder.DropIndex(
                name: "IX_Orderlines_UserId",
                table: "Orderlines");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Orderlines");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Orderlines");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Orderlines");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Orderlines");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Orderlines");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Orderlines");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Orderlines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orderlines",
                table: "Orderlines",
                columns: new[] { "UserId", "PricelistId" });
        }
    }
}
