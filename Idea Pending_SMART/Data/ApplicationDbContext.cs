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

        public DbSet<Semester> Semester { get; set; }
        public DbSet<Student> Students { get; set; }//student
        public DbSet<Class> Class { get; set; }
        public DbSet<Application> Applications { get; set; }//Applications

        public DbSet<ClassTime> ClassTimes => Set<ClassTime>();

        public DbSet<Enrollment> Enrollments => Set<Enrollment>();

        public DbSet<Student> AddStudents => Set<Student>();


    }
}
