using Idea_Pending_SMART.Interfaces;
using Idea_Pending_SMART.Models;

namespace Idea_Pending_SMART.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        //Dependency Injection of the DB Service

        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        private IRepository<Semester> _Semester;
        private IRepository<Class> _Class;
        private IRepository<Enrollment> _Enrollment;
        private IRepository<Student> _Student;
        private IRepository<Application> _Application;
        private IRepository<School> _School;
        private IRepository<Course> _Course;
        private IRepository<ClassTime> _ClassTime;
        private IRepository<Assignment> _Assignment;
        private IRepository<ApplicationUser> _ApplicationUser;
        private IRepository<Sponsor> _Sponsor;
        private IRepository<StudentNote> _StudentNote;
        private IRepository<Person> _Person;

        public IRepository<Assignment> Assignment
        {
            get
            {

                _Assignment ??= new Repository<Assignment>(_dbContext);
                return _Assignment;
            }
        }

        public IRepository<ApplicationUser> ApplicationUser
        {
            get
            {

                _ApplicationUser ??= new Repository<ApplicationUser>(_dbContext);
                return _ApplicationUser;
            }
        }
        public IRepository<Course> Course
        {
            get
            {

                _Course ??= new Repository<Course>(_dbContext);
                return _Course;
            }
        }

        public IRepository<School> School
        {
            get
            {

                _School ??= new Repository<School>(_dbContext);
                return _School;
            }
        }
        public IRepository<Semester> Semester
        {
            get
            {

                _Semester ??= new Repository<Semester>(_dbContext);
                return _Semester;
            }
        }
        public IRepository<Class> Class
        {
            get
            {

                _Class ??= new Repository<Class>(_dbContext);
                return _Class;
            }
        }
        public IRepository<Enrollment> Enrollment
        {
            get
            {

                _Enrollment ??= new Repository<Enrollment>(_dbContext);
                return _Enrollment;
            }
        }

        public IRepository<Student> Student
        {
            get
            {

                _Student ??= new Repository<Student>(_dbContext);
                return _Student;
            }
        }
        public IRepository<ClassTime> ClassTime
        {
            get
            {

                _ClassTime ??= new Repository<ClassTime>(_dbContext);
                return _ClassTime;
            }
        }

        public IRepository<Application> Application
        {
            get
            {

                _Application ??= new Repository<Application>(_dbContext);
                return _Application;
            }
        }
        public IRepository<Sponsor> Sponsor
        {
            get
            {

                _Sponsor ??= new Repository<Sponsor>(_dbContext);
                return _Sponsor;
            }
        }
        public IRepository<StudentNote> StudentNote
        {
            get
            {

                _StudentNote ??= new Repository<StudentNote>(_dbContext);
                return _StudentNote;
            }
        }
        public IRepository<Person> Person
        {
            get
            {

                _Person ??= new Repository<Person>(_dbContext);
                return _Person;
            }
        }


        //DO NOT TOUCH BELOW
        public async Task<int> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
