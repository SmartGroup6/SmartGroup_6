using Idea_Pending_SMART.Models;
using Idea_Pending_SMART.Interfaces;

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

        public IRepository<Semester> Semester
        {
            get
            {

                _Semester ??= new Repository<Semester>(_dbContext);
                return _Semester;
            }
        }




        //TO NOT TOUCH BELOW
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

