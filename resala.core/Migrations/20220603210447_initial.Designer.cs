﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using resala.core.Persistence.Contexts;

namespace resala.core.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220603210447_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("resala.core.Domain.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Name = "Qwafel"
                        });
                });

            modelBuilder.Entity("resala.core.Domain.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Name = "Maadi",
                            Phone = "01111111111"
                        },
                        new
                        {
                            Id = 101,
                            Name = "October",
                            Phone = "02222222222"
                        });
                });

            modelBuilder.Entity("resala.core.Domain.Models.Committee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("CommitteeType")
                        .HasColumnType("tinyint");

                    b.Property<int>("FemaleCapacity")
                        .HasColumnType("int");

                    b.Property<int>("MaleCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UniSexCapacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Committees");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            CommitteeType = (byte)1,
                            FemaleCapacity = 0,
                            MaleCapacity = 0,
                            Name = "HR",
                            UniSexCapacity = 0
                        },
                        new
                        {
                            Id = 101,
                            CommitteeType = (byte)2,
                            FemaleCapacity = 0,
                            MaleCapacity = 0,
                            Name = "RnD",
                            UniSexCapacity = 0
                        });
                });

            modelBuilder.Entity("resala.core.Domain.Models.ResponsibleVolunteer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcademicYear")
                        .HasColumnType("int");

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ActivityJoinDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int?>("CommitteeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DrMeetingQualificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EducationalDegree")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExitDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExitReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faculty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FemaleRelativeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("FemaleRelativeRelation")
                        .HasColumnType("tinyint");

                    b.Property<string>("FemalteRelativePhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Gender")
                        .HasColumnType("tinyint");

                    b.Property<bool>("Graduated")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("GraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GraduationGroupNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GraduationInterviewQualificationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActivityPolicyAgreed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDataPrivacyPolicyAgreed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDrMeetingQualifed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGraduationInterviewQualifed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLeadersCampQualifed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMiniCampQualifed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOmraWinner")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSocialMediaGroupsMember")
                        .HasColumnType("bit");

                    b.Property<string>("JoiningObjectives")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LeadersCampQualificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MaleRelativeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaleRelativePhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("MaleRelativeRelation")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("MiniCampQualificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalIdCopy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalIdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OmraTravelDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("OmraWinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Position")
                        .HasColumnType("tinyint");

                    b.Property<string>("PreviousExperince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ResalaGraduated")
                        .HasColumnType("bit");

                    b.Property<string>("ResidenceArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("VolunteerType")
                        .HasColumnType("tinyint");

                    b.Property<byte>("WorkingStatus")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("BranchId");

                    b.HasIndex("CommitteeId");

                    b.ToTable("ResponsibleVolunteers");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            AcademicYear = 5,
                            ActivityId = 100,
                            ActivityJoinDate = new DateTime(2022, 6, 3, 23, 4, 46, 783, DateTimeKind.Local).AddTicks(593),
                            BranchId = 100,
                            CommitteeId = 100,
                            DateOfBirth = new DateTime(2022, 6, 3, 23, 4, 46, 779, DateTimeKind.Local).AddTicks(7283),
                            EducationalDegree = 4,
                            Email = "test@test.com",
                            Faculty = "engineering",
                            FemaleRelativeName = "mother",
                            FemaleRelativeRelation = (byte)1,
                            FemalteRelativePhoneNumber = "00000000000",
                            Gender = (byte)1,
                            Graduated = true,
                            IsActivityPolicyAgreed = true,
                            IsDataPrivacyPolicyAgreed = true,
                            IsDrMeetingQualifed = false,
                            IsGraduationInterviewQualifed = false,
                            IsLeadersCampQualifed = false,
                            IsMiniCampQualifed = false,
                            IsOmraWinner = false,
                            IsSocialMediaGroupsMember = true,
                            JoiningObjectives = "blabla",
                            MaleRelativeName = "father",
                            MaleRelativePhoneNumber = "00000000000",
                            MaleRelativeRelation = (byte)1,
                            Name = "TestUser0",
                            NationalIdCopy = "ss/ss/ss.png",
                            NationalIdNumber = "11111111111111",
                            Notes = "asdfasdf",
                            Phone = "00000000000",
                            Position = (byte)8,
                            PreviousExperince = "blabla",
                            ProfileImage = "/dd/dd/d.png",
                            ResalaGraduated = false,
                            ResidenceArea = "garden city",
                            Specialization = "comm",
                            University = "cairo",
                            VolunteerType = (byte)4,
                            WorkingStatus = (byte)1
                        });
                });

            modelBuilder.Entity("resala.core.Domain.Models.TrackRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AttendedDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("Expenses")
                        .HasColumnType("int");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<bool?>("IsSettled")
                        .HasColumnType("bit");

                    b.Property<string>("RequiredInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResponsibleVolunteerId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint");

                    b.Property<int?>("TrackerId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResponsibleVolunteerId");

                    b.HasIndex("TrackerId");

                    b.ToTable("TrackRecords");
                });

            modelBuilder.Entity("resala.core.Domain.Models.Tracker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte>("Location")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("RecordPeriodDays")
                        .HasColumnType("int");

                    b.Property<string>("RequiredInfoHint")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Trackers");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Description = "TestTracker",
                            Location = (byte)1,
                            Name = "Test",
                            RecordPeriodDays = 0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("resala.core.Domain.Models.ResponsibleVolunteer", b =>
                {
                    b.HasOne("resala.core.Domain.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("resala.core.Domain.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("resala.core.Domain.Models.Committee", "Committee")
                        .WithMany()
                        .HasForeignKey("CommitteeId");

                    b.Navigation("Activity");

                    b.Navigation("Branch");

                    b.Navigation("Committee");
                });

            modelBuilder.Entity("resala.core.Domain.Models.TrackRecord", b =>
                {
                    b.HasOne("resala.core.Domain.Models.ResponsibleVolunteer", "Volunteer")
                        .WithMany()
                        .HasForeignKey("ResponsibleVolunteerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("resala.core.Domain.Models.Tracker", "Tracker")
                        .WithMany()
                        .HasForeignKey("TrackerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tracker");

                    b.Navigation("Volunteer");
                });
#pragma warning restore 612, 618
        }
    }
}
