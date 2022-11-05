using Idea_Pending_SMART.Data;
using Idea_Pending_SMART.Models;
using Idea_Pending_SMART.Interfaces;

namespace Idea_Pending_SMART.FilesToSort
{
    public class EFRepository : IRepository
    {
        private ApplicationDbContext context;

        public EFRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        //throws to remove errors until IQueryable is implemented
        public IQueryable<ClassroomList> Classrooms => throw new NotImplementedException();

        public IQueryable<Student> Students => throw new NotImplementedException();

        //  public IQueryable<ClassroomList> Classrooms => context.Classroom;
        //   public IQueryable<Enrollment> Enrollments => context.Enrollments;
        //    public IQueryable<Student> Students => context.AddStudents;

    }
}