using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace resala.core.Migrations
{
    public partial class trackers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trackers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Location = table.Column<byte>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    RequiredInfo = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trackers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ResponsibleVolunteer",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActivityJoinDate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 5, 18, 41, 57, 916, DateTimeKind.Local).AddTicks(5884), new DateTime(2022, 5, 5, 18, 41, 57, 913, DateTimeKind.Local).AddTicks(3780) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trackers");

            migrationBuilder.UpdateData(
                table: "ResponsibleVolunteer",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActivityJoinDate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 5, 5, 18, 38, 31, 8, DateTimeKind.Local).AddTicks(2326), new DateTime(2022, 5, 5, 18, 38, 31, 5, DateTimeKind.Local).AddTicks(2109) });
        }
    }
}
