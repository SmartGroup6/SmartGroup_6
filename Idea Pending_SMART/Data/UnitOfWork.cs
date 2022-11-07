﻿using Idea_Pending_SMART.Models;
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
        private IRepository<Class> _Class;
        private IRepository<Enrollment> _Enrollment;

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

