using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FineTable.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seededdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FineTable",
                columns: new[] { "Id", "Amount", "MemberType" },
                values: new object[,]
                {
                    { 1, 50, 0 },
                    { 2, 10, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FineTable",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FineTable",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
