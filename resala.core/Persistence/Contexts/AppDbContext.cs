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
        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Volunteers //

            //builder.Entity<Volunteer>()
            //    .ToTable("Volunteers")
            //    .HasKey(p => p.Id);

            //builder.Entity<Volunteer>().Property(p => p.Id)
            //    .IsRequired()
            //    .ValueGeneratedOnAdd();

            //builder.Entity<Volunteer>().Property(p => p.Name)
            //   .IsRequired()
            //   .HasMaxLength(30);

            //builder.Entity<Volunteer>().Property(p => p.Phone)
            //    .IsRequired()
            //    .HasMaxLength(11);

            //builder.Entity<Volunteer>().Property(p => p.Gender).IsRequired();


            //builder.Entity<Volunteer>().HasOne(p => p.Branch).WithMany(b => b.Volunteers).HasForeignKey(v => v.BranchId);

            //builder.Entity<Volunteer>().HasOne(p => p.Committee).WithMany(b => b.Volunteers).HasForeignKey(v => v.CommitteeId);



            //// Branch //

            //builder.Entity<Branch>()
            //  .ToTable("Branches")
            //  .HasKey(p => p.Id);

            //builder.Entity<Branch>().Property(p => p.Id)
            //  .IsRequired()
            //  .ValueGeneratedOnAdd();

            //builder.Entity<Branch>().Property(p => p.Name).IsRequired();


            // Data samples //

            builder.Entity<Branch>().HasData
                (
                    new Branch { Id = 100,Name="Maadi" , Phone="01111111111" },
                    new Branch { Id = 101,Name="October", Phone="02222222222"}
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

                        ResalaGraduated = true,
                        GraduationDate = System.DateTime.Now,
                        GraduationGroupNumber = "39",

                        IsOmraWinner = true,
                        OmraWinDate = System.DateTime.Now,
                        OmraTravelDate = System.DateTime.Now,

                        IsMiniCampQualifed = true,
                        MiniCampQualificationDate = System.DateTime.Now,

                        IsLeadersCampQualifed = true,
                        LeadersCampQualificationDate = System.DateTime.Now,

                        IsGraduationInterviewQualifed = true,
                        GraduationInterviewQualificationDate = System.DateTime.Now,

                        IsDrMeetingQualifed = true,
                        DrMeetingQualificationDate = System.DateTime.Now,

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

                        ExitDate = System.DateTime.Now,



                        Notes= "asdfasdf"
                                           
                    }
                ); ;
        }
    }
}
