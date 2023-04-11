using c135api.CustomMigrations;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace c135api.Migrations
{
    /// <inheritdoc />
    public partial class blokmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            BlokMigration.Seed(migrationBuilder);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
