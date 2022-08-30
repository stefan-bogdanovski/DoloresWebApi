using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddPropertiesToOrderEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmedPurchase",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "CVV",
                table: "Orders",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardType",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreditCardNumber",
                table: "Orders",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVV",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CardType",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreditCardNumber",
                table: "Orders");

            migrationBuilder.AddColumn<bool>(
                name: "ConfirmedPurchase",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
