using Idea_Pending_SMART.Data;

namespace Idea_Pending_SMART.Dev_Chantel.Models
{
    public class EFClassroomRepository : IClassroomRepository
    {
        private ApplicationDbContext context;

        public EFClassroomRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Classroom> Classrooms => context.Classroom;
    }
}
