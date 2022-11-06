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
        public DbSet<School> School => Set<School>();
        public DbSet<Semester> Semester => Set<Semester>();
        public DbSet<Course> Course => Set<Course>();
        public DbSet<Person> Person => Set<Person>();
        public DbSet<Sponsor> Sponsor => Set<Sponsor>();
        public DbSet<Application> Application => Set<Application>();
        public DbSet<ClassTime> ClassTimes => Set<ClassTime>();
        public DbSet<Applicant> Applicant => Set<Applicant>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Class> Class => Set<Class>();
        public DbSet<Enrollment> Enrollments => Set<Enrollment>();
        public DbSet<Attendance> Attendance => Set<Attendance>();

<<<<<<< Updated upstream
        public DbSet<Enrollment> Enrollments => Set<Enrollment>();
=======
        public DbSet<Permissions> Permissions => Set<Permissions>();
        public DbSet<Role> Role => Set<Role>();
>>>>>>> Stashed changes

        public DbSet<StudentNote> StudentNote => Set<StudentNote>();

<<<<<<< Updated upstream
=======
        public DbSet<User> User => Set<User>();

        /*   public DbSet<Semester> Semester { get; set; }

           public DbSet<Applicant> Applicant { get; set; }

           public DbSet<Application> Application { get; set; }//application

           public DbSet<Attendance> Attendance { get; set; }//attendance

           public DbSet<Class> Class { get; set; }//class

           public DbSet<Course> Course { get; set; }//course

           public DbSet<Enrollment> Enrollment { get; set; }//enrollment

           public DbSet<Permissions> Permissions { get; set; }//permissions

           public DbSet<Person> Person { get; set; }//person

           public DbSet<Role> Role { get; set; }//role

           public DbSet<School> School { get; set; }//school

           public DbSet<Sponsor> Sponsor { get; set; }//sponsor

           public DbSet<Student> Student { get; set; }//student

           public DbSet<StudentNote> StudentNote { get; set; }//studentnote

           public DbSet<User> User { get; set; }//user*/




>>>>>>> Stashed changes

    }
}