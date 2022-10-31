using Idea_Pending_SMART.Data;
using Idea_Pending_SMART.Dev_Chantel.Models;

namespace Idea_Pending_SMART.Models
{
    public class EFRepository : IRepository
    {
        private ApplicationDbContext context;

        public EFRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ClassroomList> Classrooms => context.Classroom;
        public IQueryable<Enrollment> Enrollments => context.Enrollments;
        public IQueryable<Student> Students => context.AddStudents;

    }
}
