using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace c135api.Migrations
{
    /// <inheritdoc />
    public partial class rolepermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Pin = table.Column<string>(type: "text", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    FatherId = table.Column<int>(type: "integer", nullable: true),
                    MotherId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citizens_Citizens_FatherId",
                        column: x => x.FatherId,
                        principalTable: "Citizens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Citizens_Citizens_MotherId",
                        column: x => x.MotherId,
                        principalTable: "Citizens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Citizens_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermissionRole",
                columns: table => new
                {
                    PermissionsId = table.Column<int>(type: "integer", nullable: false),
                    RolesRoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionRole", x => new { x.PermissionsId, x.RolesRoleId });
                    table.ForeignKey(
                        name: "FK_PermissionRole_Permissions_PermissionsId",
                        column: x => x.PermissionsId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissionRole_Roles_RolesRoleId",
                        column: x => x.RolesRoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_CityId",
                table: "Citizens",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_FatherId",
                table: "Citizens",
                column: "FatherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_MotherId",
                table: "Citizens",
                column: "MotherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRole_RolesRoleId",
                table: "PermissionRole",
                column: "RolesRoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citizens");

            migrationBuilder.DropTable(
                name: "PermissionRole");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Permissions");
        }
    }
}
