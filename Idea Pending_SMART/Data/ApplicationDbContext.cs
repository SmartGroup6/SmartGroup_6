using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Idea_Pending_SMART.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<School> School { get; set; }
        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<Semester> Semester { get; set; }
        public DbSet<Student> Students { get; set; }//student
        public DbSet<Class> Class { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }//enrollment
        public DbSet<Course> Course { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Sponsor> Sponsor { get; set; }
        public DbSet<ClassTime> ClassTimes { get; set; }
        public DbSet<Applicant> Applicant { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<StudentNote> StudentNote { get; set; }



        /// <summary>
        /// Seed some users to the database. Courtesy of Dr. Fry for this code.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>().HasKey(sc => new { sc.StudentID, sc.ClassID });
            base.OnModelCreating(modelBuilder);


            //Seeding Roles to AspNetRoles table

            //admin
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7211", //note this needs to be unique
                Name = "SocialWorker",
                NormalizedName = "SOCIALWORKER"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7212",
                Name = "Instructor",
                NormalizedName = "INSTRUCTOR"
            });

            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<ApplicationUser>();
            //Seeding the User to AspNetUsers table
            modelBuilder.Entity<ApplicationUser>().HasData(

                //Admin
                new ApplicationUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // UNIQUE primary key
                    ApplicationUserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",  //duplicated here
                    UserName = "Admin@Admin.com",
                    Email = "Admin@Admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    FirstName = "Hank",  //note specific fields may vary depending on how you extended the Identity model with your own user properties and fiels
                    LastName = "Hill",
                    Address = "123 Flicka Flacka Way",
                    StreetAddress = "123 Flicka Flacka Way",
                    City = "Jonestown",
                    County = "Davis",
                    Zip = "84040",
                    PostalCode = "84040",
                    PhoneNumber = "800calladmin",
                    PhoneNumberConfirmed = false,
                    Gender = "",
                    Race = "",
                    BirthDate = DateTime.Now,
                    Income = "",
                    Education = "",
                    Residence = "",
                    Military = "",
                    NormalizedUserName = "ADMIN@ADMIN.COM",
                    PasswordHash = hasher.HashPassword(null, "Temp1234$"),
                    EmailConfirmed = false,
                    SecurityStamp = "6d4fb098-23b1-4219-8b4c-c146830ede28",  //make anything up
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    State = "Texas",
                   
                    AccessFailedCount = 0
                },

                //SocialWorker1
                new ApplicationUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb8", 
                    ApplicationUserId = "8e445865-a24d-4543-a6c6-9443d048cdb8", 
                    UserName = "SocialWorker1SocialWorker1.com",
                    Email = "SocialWorker1@SocialWorker1.com",
                    NormalizedEmail = "SOCIALWORKER1@SOCIALWORKER1.COM",
                    FirstName = "Bob",  
                    LastName = "Propane",
                    Address = "1234423312 Flicka Flacka Way",
                    StreetAddress = "123 Flicka Flacka Way",
                    City = "Jonestown22",
                    County = "111111Davis",
                    Zip = "84040",
                    PostalCode = "84040",
                    PhoneNumber = "800calladmin",
                    PhoneNumberConfirmed = false,
                    Gender = "",
                    Race = "",
                    BirthDate = DateTime.Now,
                    Income = "",
                    Education = "",
                    Residence = "",
                    Military = "",
                    NormalizedUserName = "SocialWorker1SocialWorker1.com",
                    PasswordHash = hasher.HashPassword(null, "Temp1234$"),
                    EmailConfirmed = false,
                    SecurityStamp = "6d4fb098-23b1-4219-8b4c-c146830ede28", 
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    State = "Texas",

                    AccessFailedCount = 0
                },

                //SocialWorker2
                new ApplicationUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb7",
                    ApplicationUserId = "8e445865-a24d-4543-a6c6-9443d048cdb7",
                    UserName = "SocialWorker2@SocialWorker2.com",
                    Email = "SocialWorker2@SocialWorker2.com",
                    NormalizedEmail = "SocialWorker2@SocialWorker2.COM",
                    FirstName = "Miachael",
                    LastName = "Bluth",
                    Address = "123 Flicka Flacka Way",
                    StreetAddress = "123 Flicka Flacka Way",
                    City = "Jonestown",
                    County = "Davis",
                    Zip = "84040",
                    PostalCode = "84040",
                    PhoneNumber = "800calladmin",
                    PhoneNumberConfirmed = false,
                    Gender = "",
                    Race = "",
                    BirthDate = DateTime.Now,
                    Income = "",
                    Education = "",
                    Residence = "",
                    Military = "",
                    NormalizedUserName = "SocialWorker2@SocialWorker2.COM",
                    PasswordHash = hasher.HashPassword(null, "Temp1234$"),
                    EmailConfirmed = false,
                    SecurityStamp = "6d4fb098-23b1-4219-8b4c-c146830ede28",
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    State = "Texas",

                    AccessFailedCount = 0
                },

                //Instructor1
                new ApplicationUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb6",
                    ApplicationUserId = "8e445865-a24d-4543-a6c6-9443d048cdb6",
                    UserName = "Instructor1@Instructor1.com",
                    Email = "Instructor1@Instructor1.com",
                    NormalizedEmail = "Instructor1@Instructor1.COM",
                    FirstName = "Gob",
                    LastName = "Gobbo",
                    Address = "123 Flicka Flacka Way",
                    StreetAddress = "123 Flicka Flacka Way",
                    City = "Jonestown",
                    County = "Davis",
                    Zip = "84040",
                    PostalCode = "84040",
                    PhoneNumber = "800calladmin",
                    PhoneNumberConfirmed = false,
                    Gender = "",
                    Race = "",
                    BirthDate = DateTime.Now,
                    Income = "",
                    Education = "",
                    Residence = "",
                    Military = "",
                    NormalizedUserName = "Instructor1@Instructor1.COM",
                    PasswordHash = hasher.HashPassword(null, "Temp1234$"),
                    EmailConfirmed = false,
                    SecurityStamp = "6d4fb098-23b1-4219-8b4c-c146830ede28",
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    State = "Texas",

                    AccessFailedCount = 0
                },

                //Instructor2
                new ApplicationUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb5",
                    ApplicationUserId = "8e445865-a24d-4543-a6c6-9443d048cdb5",
                    UserName = "Instructor2@Instructor2.com",
                    Email = "Instructor2@Instructor2.com",
                    NormalizedEmail = "Instructor2@Instructor2.COM",
                    FirstName = "MrTeacher",
                    LastName = "MrTeacher",
                    Address = "123 Flicka Flacka Way",
                    StreetAddress = "123 Flicka Flacka Way",
                    City = "Jonestown",
                    County = "Davis",
                    Zip = "84040",
                    PostalCode = "84040",
                    PhoneNumber = "800calladmin",
                    PhoneNumberConfirmed = false,
                    Gender = "",
                    Race = "",
                    BirthDate = DateTime.Now,
                    Income = "",
                    Education = "",
                    Residence = "",
                    Military = "",
                    NormalizedUserName = "Instructor2@Instructor2.COM",
                    PasswordHash = hasher.HashPassword(null, "Temp1234$"),
                    EmailConfirmed = false,
                    SecurityStamp = "6d4fb098-23b1-4219-8b4c-c146830ede28",
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    State = "Texas",

                    AccessFailedCount = 0
                }
            );


            //Seeding the relation between our MANY users and and their MANY roles to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(

                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",  //ADMIN
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"   //Catherine
                },
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",  //SocialWorker
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb8"   //SocialWorker1
                },                                                                               
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211", //SocialWorker
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb7"  //SocialWorker2
                },
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7212", //Instructor
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb6"  //Instructor1
                },
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7212", //Instructor
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb5" //Instructor2
                }
            );

        }
    }
}