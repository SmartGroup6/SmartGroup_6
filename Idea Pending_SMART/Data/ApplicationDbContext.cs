using Idea_Pending_SMART.Dev_Chantel.Models;
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

        public DbSet<ClassroomList> Classroom => Set<ClassroomList>();

        public DbSet<ClassTime> ClassTimes => Set<ClassTime>();

        public DbSet<Enrollment> Enrollments => Set<Enrollment>();

        public DbSet<Student> AddStudents => Set<Student>();


    }
}