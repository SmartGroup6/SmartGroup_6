
using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static Idea_Pending_SMART.Data.DbContextSeeder;

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
        //public DbSet<Role> Role { get; set; }
        public DbSet<StudentNote> StudentNote { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }


        /// <summary>
        /// Seed some users to the database. Courtesy of Dr. Fry for this code.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Enrollment>().HasKey(sc => new { sc.StudentID, sc.ClassID });
            base.OnModelCreating(modelBuilder);

            DbContextSeeder dbcs = new DbContextSeeder();

            //So, role permissions can be a bit complicated.
            //ApplicationUser are the users. IdentityRole is their role.
            //Matching IndentityRole Id on RolePermission's RoleId will give all the roles that use that permission.
            //Matching RolePermission's PermissionId will give all the permissions, tied to that rolePermission, and therefore the Role that has that permission.
            //  Essentially, there is a unique RolePermission for every Role's permission. Ex, if 5 roles have 'CanEditApplicatons',
            //      there are 5 separate RolePermissions, each with a RoleId that links them to one of those 5 roles, but 
            //      their PermissionId will all be the same one for 'CanEditApplicatons''s Id.
            dbcs.UserSeeder(modelBuilder);
            dbcs.RolesSeeder(modelBuilder);
            dbcs.PermissionsSeeder(modelBuilder);
            dbcs.RolePermissionsSeeder(modelBuilder);
        }
    }

}