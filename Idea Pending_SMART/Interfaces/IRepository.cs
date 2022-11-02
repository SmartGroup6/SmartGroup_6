using Idea_Pending_SMART.Dev_Chantel.Models;

namespace Idea_Pending_SMART.Interfaces
{
    public interface IRepository
    {
        IQueryable<ClassroomList> Classrooms { get; }
        IQueryable<Student> Students { get; }
    }
}
