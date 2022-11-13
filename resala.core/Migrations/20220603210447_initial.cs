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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Committees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaleCapacity = table.Column<int>(type: "int", nullable: false),
                    FemaleCapacity = table.Column<int>(type: "int", nullable: false),
                    UniSexCapacity = table.Column<int>(type: "int", nullable: false),
                    CommitteeType = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Committees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trackers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequiredInfoHint = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    RecordPeriodDays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trackers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResponsibleVolunteers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaleRelativeRelation = table.Column<byte>(type: "tinyint", nullable: false),
                    MaleRelativeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaleRelativePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FemaleRelativeRelation = table.Column<byte>(type: "tinyint", nullable: false),
                    FemaleRelativeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FemalteRelativePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResalaGraduated = table.Column<bool>(type: "bit", nullable: false),
                    GraduationGroupNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsOmraWinner = table.Column<bool>(type: "bit", nullable: false),
                    OmraWinDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OmraTravelDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsMiniCampQualifed = table.Column<bool>(type: "bit", nullable: false),
                    MiniCampQualificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsLeadersCampQualifed = table.Column<bool>(type: "bit", nullable: false),
                    LeadersCampQualificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDrMeetingQualifed = table.Column<bool>(type: "bit", nullable: false),
                    DrMeetingQualificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsGraduationInterviewQualifed = table.Column<bool>(type: "bit", nullable: false),
                    GraduationInterviewQualificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    ActivityJoinDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JoiningObjectives = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousExperince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalIdCopy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActivityPolicyAgreed = table.Column<bool>(type: "bit", nullable: false),
                    IsDataPrivacyPolicyAgreed = table.Column<bool>(type: "bit", nullable: false),
                    WorkingStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    Position = table.Column<byte>(type: "tinyint", nullable: false),
                    CommitteeId = table.Column<int>(type: "int", nullable: true),
                    IsSocialMediaGroupsMember = table.Column<bool>(type: "bit", nullable: false),
                    ExitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExitReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<byte>(type: "tinyint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NationalIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidenceArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationalDegree = table.Column<int>(type: "int", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Faculty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademicYear = table.Column<int>(type: "int", nullable: false),
                    Graduated = table.Column<bool>(type: "bit", nullable: false),
                    VolunteerType = table.Column<byte>(type: "tinyint", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "TrackRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AttendedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponsibleVolunteerId = table.Column<int>(type: "int", nullable: false),
                    TrackerId = table.Column<int>(type: "int", nullable: false),
                    Expenses = table.Column<int>(type: "int", nullable: false),
                    IsSettled = table.Column<bool>(type: "bit", nullable: true),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    RequiredInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Name" },
                values: new object[] { 100, "Qwafel" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[,]
                {
                    { 100, "Maadi", "01111111111" },
                    { 101, "October", "02222222222" }
                });

            migrationBuilder.InsertData(
                table: "Committees",
                columns: new[] { "Id", "CommitteeType", "FemaleCapacity", "MaleCapacity", "Name", "UniSexCapacity" },
                values: new object[,]
                {
                    { 100, (byte)1, 0, 0, "HR", 0 },
                    { 101, (byte)2, 0, 0, "RnD", 0 }
                });

            migrationBuilder.InsertData(
                table: "Trackers",
                columns: new[] { "Id", "Description", "Location", "Name", "RecordPeriodDays", "RequiredInfoHint" },
                values: new object[] { 100, "TestTracker", (byte)1, "Test", 0, null });

            migrationBuilder.InsertData(
                table: "ResponsibleVolunteers",
                columns: new[] { "Id", "AcademicYear", "ActivityId", "ActivityJoinDate", "BranchId", "CommitteeId", "DateOfBirth", "DrMeetingQualificationDate", "EducationalDegree", "Email", "ExitDate", "ExitReason", "Faculty", "FemaleRelativeName", "FemaleRelativeRelation", "FemalteRelativePhoneNumber", "Gender", "Graduated", "GraduationDate", "GraduationGroupNumber", "GraduationInterviewQualificationDate", "IsActivityPolicyAgreed", "IsDataPrivacyPolicyAgreed", "IsDrMeetingQualifed", "IsGraduationInterviewQualifed", "IsLeadersCampQualifed", "IsMiniCampQualifed", "IsOmraWinner", "IsSocialMediaGroupsMember", "JoiningObjectives", "LeadersCampQualificationDate", "MaleRelativeName", "MaleRelativePhoneNumber", "MaleRelativeRelation", "MiniCampQualificationDate", "Name", "NationalIdCopy", "NationalIdNumber", "Notes", "OmraTravelDate", "OmraWinDate", "Phone", "Position", "PreviousExperince", "ProfileImage", "ResalaGraduated", "ResidenceArea", "Specialization", "University", "VolunteerType", "WorkingStatus" },
                values: new object[] { 100, 5, 100, new DateTime(2022, 6, 3, 23, 4, 46, 783, DateTimeKind.Local).AddTicks(593), 100, 100, new DateTime(2022, 6, 3, 23, 4, 46, 779, DateTimeKind.Local).AddTicks(7283), null, 4, "test@test.com", null, null, "engineering", "mother", (byte)1, "00000000000", (byte)1, true, null, null, null, true, true, false, false, false, false, false, true, "blabla", null, "father", "00000000000", (byte)1, null, "TestUser0", "ss/ss/ss.png", "11111111111111", "asdfasdf", null, null, "00000000000", (byte)8, "blabla", "/dd/dd/d.png", false, "garden city", "comm", "cairo", (byte)4, (byte)1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "TrackRecords");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
