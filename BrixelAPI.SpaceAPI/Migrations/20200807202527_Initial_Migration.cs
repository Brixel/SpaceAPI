using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BrixelAPI.SpaceState.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpaceStateChangedLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsOpen = table.Column<bool>(nullable: false),
                    ChangedByUser = table.Column<string>(nullable: false),
                    ChangedAtDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpaceStateChangedLog", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpaceStateChangedLog_IsOpen_ChangedAtDateTime_ChangedByUser",
                table: "SpaceStateChangedLog",
                columns: new[] { "IsOpen", "ChangedAtDateTime", "ChangedByUser" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpaceStateChangedLog");
        }
    }
}
