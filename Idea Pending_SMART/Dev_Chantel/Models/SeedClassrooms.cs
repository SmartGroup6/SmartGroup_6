using Idea_Pending_SMART.Data;
using Microsoft.EntityFrameworkCore;

namespace Idea_Pending_SMART.Dev_Chantel.Models
{
    public class SeedClassrooms
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
                    new Classroom
                    {
                        UserID = 123,
                        ClassDescription = "An english 1 class",
                        StudentCount = 15,
                        CourseID = 275,
                        ClassTimeID = 2,
                        SemesterID = 12
                    },
                    new Classroom {
                        UserID = 777,
                        ClassDescription = "An english 3 class",
                        StudentCount = 10,
                        CourseID = 375,
                        ClassTimeID = 1,
                        SemesterID = 12
                    },
                    new Classroom
                    {
                        UserID = 727,
                        ClassDescription = "A computer 3 class",
                        StudentCount = 1,
                        CourseID = 1,
                        ClassTimeID = 1,
                        SemesterID = 2
                    }
            );
                context.SaveChanges();
            }
        }
    }
}

