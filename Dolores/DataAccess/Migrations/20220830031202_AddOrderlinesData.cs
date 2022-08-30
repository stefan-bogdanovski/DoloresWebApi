using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddOrderlinesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orderlines",
                columns: new[] { "PricelistId", "UserId", "OrderId", "Quantity" },
                values: new object[] { 3, 1, null, 5 });

            migrationBuilder.InsertData(
                table: "Orderlines",
                columns: new[] { "PricelistId", "UserId", "OrderId", "Quantity" },
                values: new object[] { 2, 1, null, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orderlines",
                keyColumns: new[] { "PricelistId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Orderlines",
                keyColumns: new[] { "PricelistId", "UserId" },
                keyValues: new object[] { 3, 1 });
        }
    }
}
