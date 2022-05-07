using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace resala.core.Migrations
{
    public partial class TrackRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Committees",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ResponsibleVolunteers",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Committees",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.RenameColumn(
                name: "RequiredInfo",
                table: "Trackers",
                newName: "RequiredInfoHint");

            migrationBuilder.CreateTable(
                name: "TrackRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AttendedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecordPeriodDays = table.Column<int>(type: "INTEGER", nullable: false),
                    ResponsibleVolunteerId = table.Column<int>(type: "INTEGER", nullable: false),
                    TrackerId = table.Column<int>(type: "INTEGER", nullable: false),
                    Expenses = table.Column<int>(type: "INTEGER", nullable: false),
                    IsSettled = table.Column<bool>(type: "INTEGER", nullable: true),
                    Hours = table.Column<int>(type: "INTEGER", nullable: false),
                    RequiredInfo = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrackRecords_ResponsibleVolunteers_ResponsibleVolunteerId",
                        column: x => x.ResponsibleVolunteerId,
                        principalTable: "ResponsibleVolunteers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackRecords_Trackers_TrackerId",
                        column: x => x.TrackerId,
                        principalTable: "Trackers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrackRecords_ResponsibleVolunteerId",
                table: "TrackRecords",
                column: "ResponsibleVolunteerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrackRecords_TrackerId",
                table: "TrackRecords",
                column: "TrackerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrackRecords");

            migrationBuilder.RenameColumn(
                name: "RequiredInfoHint",
                table: "Trackers",
                newName: "RequiredInfo");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Name" },
                values: new object[] { 100, "Qwafel" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[] { 100, "Maadi", "01111111111" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[] { 101, "October", "02222222222" });

            migrationBuilder.InsertData(
                table: "Committees",
                columns: new[] { "Id", "FemaleCapacity", "MaleCapacity", "Name", "UniSexCapacity" },
                values: new object[] { 100, (ushort)0, (ushort)0, "HR", (ushort)0 });

            migrationBuilder.InsertData(
                table: "Committees",
                columns: new[] { "Id", "FemaleCapacity", "MaleCapacity", "Name", "UniSexCapacity" },
                values: new object[] { 101, (ushort)0, (ushort)0, "HR VOL", (ushort)0 });

            migrationBuilder.InsertData(
                table: "ResponsibleVolunteers",
                columns: new[] { "Id", "AcademicYear", "ActivityId", "ActivityJoinDate", "BranchId", "CommitteeId", "DateOfBirth", "DrMeetingQualificationDate", "EducationalDegree", "Email", "ExitDate", "ExitReason", "Faculty", "FemaleRelativeName", "FemaleRelativeRelation", "FemalteRelativePhoneNumber", "Gender", "Graduated", "GraduationDate", "GraduationGroupNumber", "GraduationInterviewQualificationDate", "IsActivityPolicyAgreed", "IsDataPrivacyPolicyAgreed", "IsDrMeetingQualifed", "IsGraduationInterviewQualifed", "IsLeadersCampQualifed", "IsMiniCampQualifed", "IsOmraWinner", "IsSocialMediaGroupsMember", "JoiningObjectives", "LeadersCampQualificationDate", "MaleRelativeName", "MaleRelativePhoneNumber", "MaleRelativeRelation", "MiniCampQualificationDate", "Name", "NationalIdCopy", "NationalIdNumber", "Notes", "OmraTravelDate", "OmraWinDate", "Phone", "Position", "PreviousExperince", "ProfileImage", "ResalaGraduated", "ResidenceArea", "Specialization", "University", "VolunteerType", "WorkingStatus" },
                values: new object[] { 100, (ushort)5, 100, new DateTime(2022, 5, 5, 22, 38, 23, 501, DateTimeKind.Local).AddTicks(6815), 100, 100, new DateTime(2022, 5, 5, 22, 38, 23, 498, DateTimeKind.Local).AddTicks(9952), null, 4, "test@test.com", null, null, "engineering", "mother", (byte)1, "00000000000", (byte)1, true, null, null, null, true, true, false, false, false, false, false, true, "blabla", null, "father", "00000000000", (byte)1, null, "TestUser0", "ss/ss/ss.png", "11111111111111", "asdfasdf", null, null, "00000000000", (byte)8, "blabla", "/dd/dd/d.png", false, "garden city", "comm", "cairo", (byte)4, (byte)1 });
        }
    }
}
