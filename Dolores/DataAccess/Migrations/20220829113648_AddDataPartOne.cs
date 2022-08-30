using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddDataPartOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PerfumeSize",
                table: "Sizes",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "DeletedAt", "DeletedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, "Armani", null, null },
                    { 2, null, null, "Gucci", null, null },
                    { 3, null, null, "Creed", null, null },
                    { 4, null, null, "Dior", null, null },
                    { 5, null, null, "Versace", null, null },
                    { 6, null, null, "Tom Ford", null, null },
                    { 7, null, null, "Dolce&Gabbana", null, null }
                });

            migrationBuilder.InsertData(
                table: "MeasurementUnits",
                columns: new[] { "Id", "DeletedAt", "DeletedBy", "Unit", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, "ml", null, null },
                    { 2, null, null, "dl", null, null },
                    { 3, null, null, "cl", null, null },
                    { 4, null, null, "oz.", null, null }
                });

            migrationBuilder.InsertData(
                table: "Perfumes",
                columns: new[] { "Id", "BrandId", "DeletedAt", "DeletedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 24, 1, null, null, "My Way", null, null },
                    { 7, 7, null, null, "K by Dolce&Gabbana", null, null },
                    { 6, 7, null, null, "Beauty Dolce Garden", null, null },
                    { 5, 7, null, null, "The one", null, null },
                    { 4, 7, null, null, "Light Blue Pour Homme", null, null },
                    { 3, 6, null, null, "Noir Extreme", null, null },
                    { 2, 6, null, null, "Soleil Neige", null, null },
                    { 1, 6, null, null, "Tobacco Vanille", null, null },
                    { 10, 5, null, null, "Crystal Noir", null, null },
                    { 9, 5, null, null, "Eros", null, null },
                    { 8, 5, null, null, "Bright Crystal", null, null },
                    { 13, 4, null, null, "J'adore", null, null },
                    { 12, 4, null, null, "Sauvage", null, null },
                    { 14, 4, null, null, "Homme", null, null },
                    { 20, 3, null, null, "Love In Black", null, null },
                    { 25, 1, null, null, "Armani Prive Bleu Lazuli", null, null },
                    { 26, 1, null, null, "Armani Code", null, null },
                    { 21, 2, null, null, "Guilty", null, null },
                    { 11, 4, null, null, "Miss Dior Blooming Bouquet", null, null },
                    { 23, 2, null, null, "Tears From The Moon", null, null },
                    { 22, 2, null, null, "Bloom", null, null },
                    { 16, 3, null, null, "Love In White", null, null },
                    { 17, 3, null, null, "Viking", null, null },
                    { 18, 3, null, null, "Royal Princess Oud", null, null },
                    { 19, 3, null, null, "Virgin Island Water", null, null },
                    { 15, 3, null, null, "Aventus", null, null }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "DeletedAt", "DeletedBy", "MeasurementUnitId", "PerfumeSize", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 4, null, null, 4, 1.7, null, null },
                    { 1, null, null, 1, 30.0, null, null },
                    { 2, null, null, 1, 50.0, null, null },
                    { 3, null, null, 1, 100.0, null, null },
                    { 5, null, null, 4, 3.3799999999999999, null, null }
                });

            migrationBuilder.InsertData(
                table: "PerfumeSizes",
                columns: new[] { "PerfumeId", "SizeId", "ImagePath", "PricelistPerfumeSizeId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, null, null, 10 },
                    { 4, 3, null, null, 7 },
                    { 3, 3, null, null, 2 },
                    { 2, 3, null, null, 5 },
                    { 1, 3, null, null, 3 },
                    { 26, 2, null, null, 11 },
                    { 25, 2, null, null, 11 },
                    { 24, 2, null, null, 5 },
                    { 23, 2, null, null, 3 },
                    { 22, 2, null, null, 3 },
                    { 21, 2, null, null, 3 },
                    { 20, 2, null, null, 1 },
                    { 19, 2, null, null, 1 },
                    { 18, 2, null, null, 1 },
                    { 17, 2, null, null, 1 },
                    { 16, 2, null, null, 4 },
                    { 5, 3, null, null, 7 },
                    { 6, 3, null, null, 7 },
                    { 7, 3, null, null, 7 },
                    { 8, 3, null, null, 7 },
                    { 24, 3, null, null, 7 },
                    { 23, 3, null, null, 7 },
                    { 22, 3, null, null, 7 },
                    { 21, 3, null, null, 11 },
                    { 20, 3, null, null, 1 },
                    { 19, 3, null, null, 1 },
                    { 18, 3, null, null, 1 },
                    { 15, 2, null, null, 4 },
                    { 17, 3, null, null, 1 },
                    { 15, 3, null, null, 20 },
                    { 14, 3, null, null, 2 },
                    { 13, 3, null, null, 2 },
                    { 12, 3, null, null, 2 },
                    { 11, 3, null, null, 2 },
                    { 10, 3, null, null, 2 },
                    { 9, 3, null, null, 0 },
                    { 16, 3, null, null, 2 },
                    { 14, 2, null, null, 4 },
                    { 13, 2, null, null, 1 },
                    { 12, 2, null, null, 15 },
                    { 17, 1, null, null, 2 },
                    { 16, 1, null, null, 5 }
                });

            migrationBuilder.InsertData(
                table: "PerfumeSizes",
                columns: new[] { "PerfumeId", "SizeId", "ImagePath", "PricelistPerfumeSizeId", "Quantity" },
                values: new object[,]
                {
                    { 15, 1, null, null, 5 },
                    { 14, 1, null, null, 5 },
                    { 13, 1, null, null, 5 },
                    { 12, 1, null, null, 5 },
                    { 11, 1, null, null, 5 },
                    { 18, 1, null, null, 2 },
                    { 10, 1, null, null, 5 },
                    { 8, 1, null, null, 2 },
                    { 7, 1, null, null, 2 },
                    { 6, 1, null, null, 2 },
                    { 5, 1, null, null, 2 },
                    { 4, 1, null, null, 2 },
                    { 3, 1, null, null, 7 },
                    { 2, 1, null, null, 7 },
                    { 9, 1, null, null, 2 },
                    { 25, 3, null, null, 25 },
                    { 19, 1, null, null, 2 },
                    { 21, 1, null, null, 7 },
                    { 11, 2, null, null, 0 },
                    { 10, 2, null, null, 0 },
                    { 9, 2, null, null, 5 },
                    { 8, 2, null, null, 5 },
                    { 7, 2, null, null, 5 },
                    { 6, 2, null, null, 5 },
                    { 5, 2, null, null, 5 },
                    { 20, 1, null, null, 2 },
                    { 4, 2, null, null, 5 },
                    { 2, 2, null, null, 2 },
                    { 1, 2, null, null, 5 },
                    { 26, 1, null, null, 14 },
                    { 25, 1, null, null, 14 },
                    { 24, 1, null, null, 7 },
                    { 23, 1, null, null, 7 },
                    { 22, 1, null, null, 7 },
                    { 3, 2, null, null, 5 },
                    { 26, 3, null, null, 25 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "PerfumeSize",
                table: "Sizes",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
