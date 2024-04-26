using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_System_Menagment_Infrastuctor.Migrations
{
    public partial class config : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AllProducts",
                columns: new[] { "ID", "GoodPrice", "Invoiceid", "Name", "Quantity", "SaleId", "SalePrice" },
                values: new object[,]
                {
                    { 1, 20.00m, null, "Piston", 12, null, 25.00m },
                    { 2, 40.00m, null, "Reel", 32, null, 48.00m },
                    { 3, 67.00m, null, "Shaft", 10, null, 75.00m },
                    { 4, 17.00m, null, "Transition", 12, null, 20.00m },
                    { 5, 18.00m, null, "Safety Cover", 15, null, 21.00m },
                    { 6, 14.00m, null, "Strap", 2, null, 17.00m },
                    { 7, 20.00m, null, "Piston H345", 34, null, 25.00m },
                    { 8, 30.00m, null, "Piston 265", 3, null, 35.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AllProducts",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AllProducts",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AllProducts",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AllProducts",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AllProducts",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AllProducts",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AllProducts",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AllProducts",
                keyColumn: "ID",
                keyValue: 8);
        }
    }
}
