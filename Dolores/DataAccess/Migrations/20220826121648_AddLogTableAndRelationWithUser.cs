using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddLogTableAndRelationWithUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UseCaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ExecutionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAuthorized = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "DeletedAt", "DeletedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, null, null, "Administrator", null, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "DeletedAt", "DeletedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 2, null, null, "Authorized", null, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "DeletedAt", "DeletedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 3, null, null, "Unauthorized", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserId",
                table: "Logs",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
