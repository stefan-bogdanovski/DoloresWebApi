using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddSomeOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryStatus",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "InProcess",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Created");

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "Method", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, "Online", null, null });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DeletedBy", "IsActive", "Method", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, "OnDeliveryToCourier", null, null });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CVV", "CardType", "CreditCardNumber", "Date", "PaymentMethodId" },
                values: new object[] { 1, "Jovana Cvijica 2", "173", "MasterCard", "0000-0000-0000-0000", new DateTime(2022, 8, 30, 14, 16, 43, 643, DateTimeKind.Utc).AddTicks(9030), 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CVV", "CardType", "CreditCardNumber", "Date", "PaymentMethodId" },
                values: new object[] { 2, "Jovana Cvijica 2", null, null, null, new DateTime(2022, 8, 30, 14, 16, 43, 643, DateTimeKind.Utc).AddTicks(9883), 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryStatus",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Created",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "InProcess");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCost",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
