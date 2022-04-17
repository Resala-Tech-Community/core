using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace resala.core.Migrations
{
    public partial class InitialMigration : Migration
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
                name: "Committee",
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
                    table.PrimaryKey("PK_Committee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResponsibleVolunteer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaleRelativeRelation = table.Column<byte>(type: "INTEGER", nullable: false),
                    MaleRelativeName = table.Column<string>(type: "TEXT", nullable: true),
                    MaleRelativeNumber = table.Column<string>(type: "TEXT", nullable: true),
                    FemaleRelativeRelation = table.Column<byte>(type: "INTEGER", nullable: false),
                    FemaleRelativeName = table.Column<string>(type: "TEXT", nullable: true),
                    FemalteRelativeNumber = table.Column<string>(type: "TEXT", nullable: true),
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
                    ActivityId = table.Column<int>(type: "INTEGER", nullable: true),
                    ActivityJoinDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    JoiningObjectives = table.Column<string>(type: "TEXT", nullable: true),
                    PreviousExperince = table.Column<string>(type: "TEXT", nullable: true),
                    ProfileImage = table.Column<string>(type: "TEXT", nullable: true),
                    NationalIdCopy = table.Column<string>(type: "TEXT", nullable: true),
                    IsActivityPolicyAgreed = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDataPrivacyPolicyAgreed = table.Column<bool>(type: "INTEGER", nullable: false),
                    WorkingStatus = table.Column<byte>(type: "INTEGER", nullable: false),
                    Position = table.Column<byte>(type: "INTEGER", nullable: false),
                    BranchId = table.Column<int>(type: "INTEGER", nullable: true),
                    CommitteeId = table.Column<int>(type: "INTEGER", nullable: true),
                    IsSocialMediaGroupsMember = table.Column<bool>(type: "INTEGER", nullable: false),
                    ExitDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExitReason = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<byte>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    NationalIdNumber = table.Column<string>(type: "TEXT", nullable: true),
                    ResidenceArea = table.Column<string>(type: "TEXT", nullable: true),
                    EducationalDegree = table.Column<int>(type: "INTEGER", nullable: false),
                    University = table.Column<string>(type: "TEXT", nullable: true),
                    Faculty = table.Column<string>(type: "TEXT", nullable: true),
                    Specialization = table.Column<string>(type: "TEXT", nullable: true),
                    AcademicYear = table.Column<ushort>(type: "INTEGER", nullable: false),
                    Graduated = table.Column<bool>(type: "INTEGER", nullable: false),
                    VolunteerType = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsibleVolunteer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponsibleVolunteer_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResponsibleVolunteer_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResponsibleVolunteer_Committee_CommitteeId",
                        column: x => x.CommitteeId,
                        principalTable: "Committee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[] { 100, "Maadi", "01111111111" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[] { 101, "October", "02222222222" });

            migrationBuilder.InsertData(
                table: "ResponsibleVolunteer",
                columns: new[] { "Id", "AcademicYear", "ActivityId", "ActivityJoinDate", "BranchId", "CommitteeId", "DateOfBirth", "DrMeetingQualificationDate", "EducationalDegree", "Email", "ExitDate", "ExitReason", "Faculty", "FemaleRelativeName", "FemaleRelativeRelation", "FemalteRelativeNumber", "Gender", "Graduated", "GraduationDate", "GraduationGroupNumber", "GraduationInterviewQualificationDate", "IsActivityPolicyAgreed", "IsDataPrivacyPolicyAgreed", "IsDrMeetingQualifed", "IsGraduationInterviewQualifed", "IsLeadersCampQualifed", "IsMiniCampQualifed", "IsOmraWinner", "IsSocialMediaGroupsMember", "JoiningObjectives", "LeadersCampQualificationDate", "MaleRelativeName", "MaleRelativeNumber", "MaleRelativeRelation", "MiniCampQualificationDate", "Name", "NationalIdCopy", "NationalIdNumber", "Notes", "OmraTravelDate", "OmraWinDate", "Phone", "Position", "PreviousExperince", "ProfileImage", "ResalaGraduated", "ResidenceArea", "Specialization", "University", "VolunteerType", "WorkingStatus" },
                values: new object[] { 100, (ushort)5, null, new DateTime(2022, 4, 16, 2, 12, 17, 917, DateTimeKind.Local).AddTicks(2053), null, null, new DateTime(2022, 4, 16, 2, 12, 17, 914, DateTimeKind.Local).AddTicks(605), new DateTime(2022, 4, 16, 2, 12, 17, 917, DateTimeKind.Local).AddTicks(1806), 4, "test@test.com", null, null, "engineering", "mother", (byte)1, "00000000000", (byte)1, true, new DateTime(2022, 4, 16, 2, 12, 17, 916, DateTimeKind.Local).AddTicks(8892), "39", new DateTime(2022, 4, 16, 2, 12, 17, 917, DateTimeKind.Local).AddTicks(1353), true, true, true, true, true, true, true, true, "blabla", new DateTime(2022, 4, 16, 2, 12, 17, 917, DateTimeKind.Local).AddTicks(902), "father", "00000000000", (byte)1, new DateTime(2022, 4, 16, 2, 12, 17, 917, DateTimeKind.Local).AddTicks(443), "TestUser0", "ss/ss/ss.png", "11111111111111", "asdfasdf", new DateTime(2022, 4, 16, 2, 12, 17, 916, DateTimeKind.Local).AddTicks(9964), new DateTime(2022, 4, 16, 2, 12, 17, 916, DateTimeKind.Local).AddTicks(9617), "00000000000", (byte)8, "blabla", "/dd/dd/d.png", true, "garden city", "comm", "cairo", (byte)4, (byte)1 });

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibleVolunteer_ActivityId",
                table: "ResponsibleVolunteer",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibleVolunteer_BranchId",
                table: "ResponsibleVolunteer",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibleVolunteer_CommitteeId",
                table: "ResponsibleVolunteer",
                column: "CommitteeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResponsibleVolunteer");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Committee");
        }
    }
}
