using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class MeasurementUnitTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MeasurementUnit",
                table: "Sizes");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeasurementUnitId",
                table: "Sizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MeasurementUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurementUnits", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_MeasurementUnitId",
                table: "Sizes",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasurementUnits_Unit",
                table: "MeasurementUnits",
                column: "Unit",
                unique: true,
                filter: "[Unit] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_MeasurementUnits_MeasurementUnitId",
                table: "Sizes",
                column: "MeasurementUnitId",
                principalTable: "MeasurementUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_MeasurementUnits_MeasurementUnitId",
                table: "Sizes");

            migrationBuilder.DropTable(
                name: "MeasurementUnits");

            migrationBuilder.DropIndex(
                name: "IX_Sizes_MeasurementUnitId",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "MeasurementUnitId",
                table: "Sizes");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AddColumn<string>(
                name: "MeasurementUnit",
                table: "Sizes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
