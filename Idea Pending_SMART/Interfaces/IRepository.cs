using Idea_Pending_SMART.Models;

namespace Idea_Pending_SMART.Interfaces
{
    public interface IRepository
    {
        IQueryable<ClassroomList> Classrooms { get; }
        IQueryable<Student> Students { get; }
    }
}
