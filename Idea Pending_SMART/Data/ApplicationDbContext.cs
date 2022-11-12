﻿using Idea_Pending_SMART.Models;
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
        //  public DbSet<Semester> Semester => Set<Semester>();
        public DbSet<Semester> Semester { get; set; }
        public DbSet<Student> Students { get; set; }//student
        public DbSet<Class> Class { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }//enrollment
        public DbSet<Course> Course { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Sponsor> Sponsor { get; set; }
        public DbSet<ClassTime> ClassTimes { get; set; }
        public DbSet<Applicant> Applicant { get; set; }
        //  public DbSet<Student> Students => Set<Student>();
        //   public DbSet<Class> Class => Set<Class>();
        //  public DbSet<Enrollment> Enrollments => Set<Enrollment>();
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<StudentNote> StudentNote { get; set; }

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


    }
}
