using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerfumeSizes_Pricelists_PricelistPerfumeSizeId",
                table: "PerfumeSizes");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Pricelists_PerfumeSizeId",
                table: "Pricelists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerfumeSizes",
                table: "PerfumeSizes");

            migrationBuilder.DropIndex(
                name: "IX_PerfumeSizes_PricelistPerfumeSizeId",
                table: "PerfumeSizes");

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 19, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 21, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 22, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 23, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "PerfumeSizes",
                keyColumns: new[] { "PerfumeId", "SizeId" },
                keyValues: new object[] { 26, 3 });

            migrationBuilder.DropColumn(
                name: "PricelistPerfumeSizeId",
                table: "PerfumeSizes");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PerfumeSizes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PerfumeSizes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "PerfumeSizes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "PerfumeSizes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PerfumeSizes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "PerfumeSizes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "PerfumeSizes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerfumeSizes",
                table: "PerfumeSizes",
                column: "Id");

            migrationBuilder.InsertData(
                table: "PerfumeSizes",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DeletedBy", "ImagePath", "IsActive", "PerfumeId", "Quantity", "SizeId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 1, 10, 1, null, null },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 19, 1, 2, null, null },
                    { 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 19, 1, 3, null, null },
                    { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 18, 2, 1, null, null },
                    { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 18, 1, 3, null, null },
                    { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 18, 1, 2, null, null },
                    { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 17, 2, 1, null, null },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 17, 1, 3, null, null },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 17, 1, 2, null, null },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 16, 5, 1, null, null },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 16, 2, 3, null, null },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 16, 4, 2, null, null },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 15, 5, 1, null, null },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 15, 20, 3, null, null },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 15, 4, 2, null, null },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 14, 5, 1, null, null },
                    { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 19, 2, 1, null, null },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 20, 1, 3, null, null },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 20, 1, 2, null, null },
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 20, 2, 1, null, null },
                    { 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 26, 25, 3, null, null },
                    { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 25, 14, 1, null, null },
                    { 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 25, 11, 2, null, null },
                    { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 25, 25, 3, null, null },
                    { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 24, 7, 1, null, null },
                    { 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 24, 5, 2, null, null },
                    { 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 24, 7, 3, null, null },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 14, 2, 3, null, null },
                    { 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 23, 7, 1, null, null },
                    { 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 23, 7, 3, null, null },
                    { 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 22, 7, 1, null, null },
                    { 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 22, 3, 2, null, null },
                    { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 22, 7, 3, null, null },
                    { 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 21, 7, 1, null, null },
                    { 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 21, 3, 2, null, null },
                    { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 21, 11, 3, null, null },
                    { 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 23, 3, 2, null, null },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 14, 4, 2, null, null },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 13, 5, 1, null, null },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 13, 2, 3, null, null },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 6, 2, 1, null, null },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 6, 7, 3, null, null }
                });

            migrationBuilder.InsertData(
                table: "PerfumeSizes",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DeletedBy", "ImagePath", "IsActive", "PerfumeId", "Quantity", "SizeId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 5, 5, 2, null, null },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 5, 2, 1, null, null },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 5, 7, 3, null, null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 4, 5, 2, null, null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 4, 2, 1, null, null },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 6, 5, 2, null, null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 4, 7, 3, null, null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 3, 2, 3, null, null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 3, 7, 1, null, null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 2, 5, 3, null, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 2, 2, 2, null, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 2, 7, 1, null, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 1, 3, 3, null, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 1, 5, 2, null, null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 3, 5, 2, null, null },
                    { 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 26, 11, 2, null, null },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 7, 7, 3, null, null },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 7, 5, 2, null, null },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 13, 1, 2, null, null },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 12, 5, 1, null, null },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 12, 2, 3, null, null },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 12, 15, 2, null, null },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 11, 5, 1, null, null },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 11, 2, 3, null, null },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 11, 0, 2, null, null },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 7, 2, 1, null, null },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 10, 5, 1, null, null },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 10, 0, 2, null, null },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 9, 5, 2, null, null },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 9, 2, 1, null, null },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 9, 0, 3, null, null },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 8, 5, 2, null, null },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 8, 2, 1, null, null },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 8, 7, 3, null, null },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 10, 2, 3, null, null },
                    { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, 26, 14, 1, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PerfumeSizes_PerfumeId",
                table: "PerfumeSizes",
                column: "PerfumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pricelists_PerfumeSizes_PerfumeSizeId",
                table: "Pricelists",
                column: "PerfumeSizeId",
                principalTable: "PerfumeSizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pricelists_PerfumeSizes_PerfumeSizeId",
                table: "Pricelists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerfumeSizes",
                table: "PerfumeSizes");

            migrationBuilder.DropIndex(
                name: "IX_PerfumeSizes_PerfumeId",
                table: "PerfumeSizes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PerfumeSizes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PerfumeSizes");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "PerfumeSizes");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "PerfumeSizes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PerfumeSizes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "PerfumeSizes");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "PerfumeSizes");

            migrationBuilder.AddColumn<int>(
                name: "PricelistPerfumeSizeId",
                table: "PerfumeSizes",
                type: "int",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Pricelists_PerfumeSizeId",
                table: "Pricelists",
                column: "PerfumeSizeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerfumeSizes",
                table: "PerfumeSizes",
                columns: new[] { "PerfumeId", "SizeId" });

            migrationBuilder.CreateIndex(
                name: "IX_PerfumeSizes_PricelistPerfumeSizeId",
                table: "PerfumeSizes",
                column: "PricelistPerfumeSizeId",
                unique: true,
                filter: "[PricelistPerfumeSizeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_PerfumeSizes_Pricelists_PricelistPerfumeSizeId",
                table: "PerfumeSizes",
                column: "PricelistPerfumeSizeId",
                principalTable: "Pricelists",
                principalColumn: "PerfumeSizeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
