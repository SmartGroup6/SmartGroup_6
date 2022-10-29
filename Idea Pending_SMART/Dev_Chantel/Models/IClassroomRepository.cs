namespace Idea_Pending_SMART.Dev_Chantel.Models
{
    public interface IClassroomRepository
    {
        IQueryable<Classroom> Classrooms { get; }  
    }
}
