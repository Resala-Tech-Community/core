using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace resala.core.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Committees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    MaleCapacity = table.Column<ushort>(type: "INTEGER", nullable: false),
                    FemaleCapacity = table.Column<ushort>(type: "INTEGER", nullable: false),
                    UniSexCapacity = table.Column<ushort>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Committees", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "ResponsibleVolunteers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaleRelativeRelation = table.Column<byte>(type: "INTEGER", nullable: false),
                    MaleRelativeName = table.Column<string>(type: "TEXT", nullable: false),
                    MaleRelativePhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    FemaleRelativeRelation = table.Column<byte>(type: "INTEGER", nullable: false),
                    FemaleRelativeName = table.Column<string>(type: "TEXT", nullable: false),
                    FemalteRelativePhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    ResalaGraduated = table.Column<bool>(type: "INTEGER", nullable: false),
                    GraduationGroupNumber = table.Column<string>(type: "TEXT", nullable: true),
                    GraduationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsOmraWinner = table.Column<bool>(type: "INTEGER", nullable: false),
                    OmraWinDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    OmraTravelDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsMiniCampQualifed = table.Column<bool>(type: "INTEGER", nullable: false),
                    MiniCampQualificationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsLeadersCampQualifed = table.Column<bool>(type: "INTEGER", nullable: false),
                    LeadersCampQualificationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDrMeetingQualifed = table.Column<bool>(type: "INTEGER", nullable: false),
                    DrMeetingQualificationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsGraduationInterviewQualifed = table.Column<bool>(type: "INTEGER", nullable: false),
                    GraduationInterviewQualificationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ActivityId = table.Column<int>(type: "INTEGER", nullable: false),
                    ActivityJoinDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    JoiningObjectives = table.Column<string>(type: "TEXT", nullable: true),
                    PreviousExperince = table.Column<string>(type: "TEXT", nullable: true),
                    ProfileImage = table.Column<string>(type: "TEXT", nullable: true),
                    NationalIdCopy = table.Column<string>(type: "TEXT", nullable: true),
                    IsActivityPolicyAgreed = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDataPrivacyPolicyAgreed = table.Column<bool>(type: "INTEGER", nullable: false),
                    WorkingStatus = table.Column<byte>(type: "INTEGER", nullable: false),
                    Position = table.Column<byte>(type: "INTEGER", nullable: false),
                    CommitteeId = table.Column<int>(type: "INTEGER", nullable: true),
                    IsSocialMediaGroupsMember = table.Column<bool>(type: "INTEGER", nullable: false),
                    ExitDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExitReason = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<byte>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NationalIdNumber = table.Column<string>(type: "TEXT", nullable: false),
                    ResidenceArea = table.Column<string>(type: "TEXT", nullable: false),
                    EducationalDegree = table.Column<int>(type: "INTEGER", nullable: false),
                    University = table.Column<string>(type: "TEXT", nullable: false),
                    Faculty = table.Column<string>(type: "TEXT", nullable: false),
                    Specialization = table.Column<string>(type: "TEXT", nullable: false),
                    AcademicYear = table.Column<ushort>(type: "INTEGER", nullable: false),
                    Graduated = table.Column<bool>(type: "INTEGER", nullable: false),
                    VolunteerType = table.Column<byte>(type: "INTEGER", nullable: false),
                    BranchId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsibleVolunteers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponsibleVolunteers_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResponsibleVolunteers_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResponsibleVolunteers_Committees_CommitteeId",
                        column: x => x.CommitteeId,
                        principalTable: "Committees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibleVolunteers_ActivityId",
                table: "ResponsibleVolunteers",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibleVolunteers_BranchId",
                table: "ResponsibleVolunteers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibleVolunteers_CommitteeId",
                table: "ResponsibleVolunteers",
                column: "CommitteeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResponsibleVolunteers");

            migrationBuilder.DropTable(
                name: "Trackers");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Committees");
        }
    }
}
