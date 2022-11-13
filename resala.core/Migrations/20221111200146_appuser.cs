using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace resala.core.Migrations
{
    public partial class appuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrackRecords_ResponsibleVolunteers_ResponsibleVolunteerId",
                table: "TrackRecords");

            migrationBuilder.DropIndex(
                name: "IX_TrackRecords_ResponsibleVolunteerId",
                table: "TrackRecords");

            migrationBuilder.AddColumn<int>(
                name: "VolunteerId",
                table: "TrackRecords",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberVolunteerID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ResponsibleVolunteers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActivityJoinDate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 11, 11, 22, 1, 45, 933, DateTimeKind.Local).AddTicks(5386), new DateTime(2022, 11, 11, 22, 1, 45, 930, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.CreateIndex(
                name: "IX_TrackRecords_VolunteerId",
                table: "TrackRecords",
                column: "VolunteerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MemberVolunteerID",
                table: "AspNetUsers",
                column: "MemberVolunteerID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ResponsibleVolunteers_MemberVolunteerID",
                table: "AspNetUsers",
                column: "MemberVolunteerID",
                principalTable: "ResponsibleVolunteers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackRecords_ResponsibleVolunteers_VolunteerId",
                table: "TrackRecords",
                column: "VolunteerId",
                principalTable: "ResponsibleVolunteers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ResponsibleVolunteers_MemberVolunteerID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackRecords_ResponsibleVolunteers_VolunteerId",
                table: "TrackRecords");

            migrationBuilder.DropIndex(
                name: "IX_TrackRecords_VolunteerId",
                table: "TrackRecords");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_MemberVolunteerID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VolunteerId",
                table: "TrackRecords");

            migrationBuilder.DropColumn(
                name: "MemberVolunteerID",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "ResponsibleVolunteers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActivityJoinDate", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 4, 46, 783, DateTimeKind.Local).AddTicks(593), new DateTime(2022, 6, 3, 23, 4, 46, 779, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.CreateIndex(
                name: "IX_TrackRecords_ResponsibleVolunteerId",
                table: "TrackRecords",
                column: "ResponsibleVolunteerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackRecords_ResponsibleVolunteers_ResponsibleVolunteerId",
                table: "TrackRecords",
                column: "ResponsibleVolunteerId",
                principalTable: "ResponsibleVolunteers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
