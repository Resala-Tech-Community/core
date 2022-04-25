using Microsoft.EntityFrameworkCore;
using resala.core.Domain.Models;
using System.Reflection;

namespace resala.core.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<ResponsibleVolunteer> ResponsibleVolunteer { get; set; }
        public DbSet<Branch> Branches { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite("Filename=TestDatabase.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });

            optionsBuilder.UseLazyLoadingProxies();
        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Data samples //

            builder.Entity<Branch>().HasData
                (
                    new Branch { Id = 100,Name="Maadi" , Phone="01111111111"  },
                    new Branch { Id = 101,Name="October", Phone="02222222222" }
                );

            builder.Entity<Committee>().HasData
               (
                   new Committee { Id = 100, Name = "HR" },
                   new Committee { Id = 101, Name = "HR VOL" }
               );

            builder.Entity<Activity>().HasData
             (
                 new Activity { Id = 100, Name = "Qwafel" }
             );



            builder.Entity<ResponsibleVolunteer>().HasData
                (
                    new ResponsibleVolunteer
                    {
                        Id = 100,
                        Name = "TestUser0",
                        Gender = Gender.Male,
                        Phone = "00000000000",
                        Email = "test@test.com",
                        DateOfBirth =  System.DateTime.Now,
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



                        Notes= "asdfasdf"
                                           
                    }
                ); ;
        }
    }
}
