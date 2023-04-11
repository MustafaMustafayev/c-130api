using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace c135api.Migrations
{
    /// <inheritdoc />
    public partial class blokseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bloks",
                columns: new[] { "Id", "Number" },
                values: new object[,]
                {
                    { 1, "1" },
                    { 2, "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bloks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bloks",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
