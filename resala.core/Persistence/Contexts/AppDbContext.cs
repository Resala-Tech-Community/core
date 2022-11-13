using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using resala.core.Domain.Models;
using resala.core.Identity;
using System.Reflection;

namespace resala.core.Persistence.Contexts
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {

        public DbSet<Tracker> Trackers { get; set; }
        public DbSet<TrackRecord> TrackRecords { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Committee> Committees { get; set; }
        public DbSet<MemberVolunteer> ResponsibleVolunteers { get; set; }

        private IConfiguration _Configuration { get; }

        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
        {
            _Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseSqlite("Filename=TestDatabase.db", options =>
            //{
            //    options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            //});

            optionsBuilder.UseSqlServer(_Configuration.GetConnectionString("LocalDB"));

            optionsBuilder.UseLazyLoadingProxies();
        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            InjectDataSamples(builder);
        }



        private void InjectDataSamples(ModelBuilder builder)
        {
            // Data samples //

            builder.Entity<Branch>().HasData
                (
                    new Branch { Id = 100, Name = "Maadi", Phone = "01111111111" },
                    new Branch { Id = 101, Name = "October", Phone = "02222222222" }
                );

            builder.Entity<Committee>().HasData
               (
                   new Committee { Id = 100, Name = "HR" , CommitteeType = CommitteeType.Branches },
                   new Committee { Id = 101, Name = "RnD" , CommitteeType = CommitteeType.Central }
               );

            builder.Entity<Activity>().HasData
             (
                 new Activity { Id = 100, Name = "Qwafel" }
             );

            builder.Entity<Tracker>().HasData
            (
                new Tracker { Id = 100, Description = "TestTracker", Location = TrackerLocation.Home, Name = "Test" }
            );



            builder.Entity<MemberVolunteer>().HasData
                (
                    new MemberVolunteer
                    {
                        Id = 100,
                        Name = "TestUser0",
                        Gender = Gender.Male,
                        Phone = "00000000000",
                        Email = "test@test.com",
                        DateOfBirth = System.DateTime.Now,
                        NationalIdNumber = "11111111111111",
                        ResidenceArea = "garden city",
                        EducationalDegree = EducationalDegree.Bachelor,
                        University = "cairo",
                        Faculty = "engineering",
                        Specialization = "comm",
                        AcademicYear = 5,
                        Graduated = true,

                        MaleRelativeRelation = MaleRelativeRelation.Father,
                        MaleRelativeName = "father",
                        MaleRelativePhoneNumber = "00000000000",

                        FemaleRelativeRelation = FemaleRelativeRelation.Mother,
                        FemaleRelativeName = "mother",
                        FemalteRelativePhoneNumber = "00000000000",

                        ResalaGraduated = false,

                        IsOmraWinner = false,

                        IsMiniCampQualifed = false,

                        IsLeadersCampQualifed = false,

                        IsGraduationInterviewQualifed = false,

                        IsDrMeetingQualifed = false,

                        ActivityJoinDate = System.DateTime.Now,
                        JoiningObjectives = "blabla",

                        PreviousExperince = "blabla",

                        ProfileImage = "/dd/dd/d.png",
                        NationalIdCopy = "ss/ss/ss.png",

                        IsActivityPolicyAgreed = true,
                        IsDataPrivacyPolicyAgreed = true,
                        IsSocialMediaGroupsMember = true,


                        WorkingStatus = VolunteeringStatus.Active,
                        Position = Position.DepartementManager,


                        BranchId = 100,
                        CommitteeId = 100,
                        ActivityId = 100,



                        Notes = "asdfasdf"

                    }
                ); ;
        }
    }
}
