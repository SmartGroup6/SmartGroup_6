using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Idea_Pending_SMART.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}
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
        public DbSet<User> User { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<StudentNote> StudentNote { get; set; }

        //  Chantel did need this later
           protected override void OnModelCreating(ModelBuilder builder)
           {
              builder.Entity<Enrollment>().HasKey(sc => new { sc.StudentID, sc.ClassID });

          base.OnModelCreating(builder);
        }

    }
}