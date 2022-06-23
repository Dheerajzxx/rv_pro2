using Microsoft.EntityFrameworkCore.Migrations;

namespace webAPi3.Migrations
{
    public partial class SeedGearsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gears",
                columns: new[] { "Id", "name", "price", "stock" },
                values: new object[] { 1, "spur", "5000", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gears",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
