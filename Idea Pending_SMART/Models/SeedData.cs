using Humanizer;
using Idea_Pending_SMART.Data;
using Idea_Pending_SMART.Models;
using Microsoft.EntityFrameworkCore;

namespace Idea_Pending_SMART.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Classroom.Any())
            {
                context.Classroom.AddRange(
                    new ClassroomList
                    {
                        UserID = 123,
                        ClassDescription = "An english 1 class",
                        StudentCount = 15,
                        CourseID = 275,
                        ClassTimeID = 2,
                        SemesterID = 12
                    },
                    new ClassroomList
                    {
                        UserID = 777,
                        ClassDescription = "An english 3 class",
                        StudentCount = 10,
                        CourseID = 375,
                        ClassTimeID = 1,
                        SemesterID = 12
                    },
                    new ClassroomList
                    {
                        UserID = 727,
                        ClassDescription = "A computer 3 class",
                        StudentCount = 1,
                        CourseID = 1,
                        ClassTimeID = 1,
                        SemesterID = 2
                    }
            ); context.SaveChanges();
            }
            if (!context.ClassTimes.Any())
            {
                context.ClassTimes.AddRange(
                    new ClassTime
                    {
                        ClassTimeID = 1,
                        Day = "Monday",
                        TimeStart = DateTime.Parse("9:00")
                    },
                    new ClassTime
                    {
                        ClassTimeID = 2,
                        Day = "Tuesday",
                        TimeStart = DateTime.Parse("11:00")
                    },
                    new ClassTime
                    {
                        ClassTimeID = 3,
                        Day = "Wednesday",
                        TimeStart = DateTime.Parse("15:00")
                    }
                    ); context.SaveChanges();
            }
            if (!context.Enrollments.Any())
            {
                context.Enrollments.AddRange(
                    new Enrollment
                    {
                        EnrollmentID = 1,
                        ClassID = 1,
                        StudentID = 1
                    },
                    new Enrollment
                    {
                        EnrollmentID = 2,
                        ClassID = 2,
                        StudentID = 2
                    },
                    new Enrollment
                    {EnrollmentID = 3,
                        ClassID = 3,
                        StudentID = 3
                    }
                    ); context.SaveChanges();
            }
            if (!context.AddStudents.Any())
            {
                context.AddStudents.AddRange(
                    new Student
                    {

                        timeAvailable = true,
                        CurrentGrade = 'B',
                        SponsorID = 0,
                        ApplicationID = 0
                    },
                    new Student
                    {

                        timeAvailable = true,
                        CurrentGrade = 'A',
                        SponsorID = 0,
                        ApplicationID = 0
                    },
                    new Student
                    {

                        timeAvailable = false,
                        CurrentGrade = 'B',
                        SponsorID = 0,
                        ApplicationID = 0
                    }

                    ); context.SaveChanges();
            }
        }
    }
}

