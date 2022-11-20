using Idea_Pending_SMART.Models;

namespace Idea_Pending_SMART.Interfaces
{
    public interface IUnitOfWork
    {
        //Data Accessors
        public IRepository<Semester> Semester { get; }
        public IRepository<Class> Class { get; }
        public IRepository<Application> Application { get; }

        public IRepository<Assignment> Assignment { get; }

        public IRepository<Enrollment> Enrollment { get; }
        public IRepository<Student> Student { get; }
        public IRepository<School> School { get; }

        public IRepository<Course> Course { get; }
        public IRepository<ClassTime> ClassTime { get; }
        public IRepository<ApplicationUser> ApplicationUser { get; }

        //save changes to data source
        void Commit();
        //same but an Asynchronous Commit
        Task<int> CommitAsync();

    }
}
