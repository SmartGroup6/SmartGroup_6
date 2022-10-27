using Idea_Pending_SMART.Models;

namespace Idea_Pending_SMART.Interfaces
{
    public interface IUnitOfWork
    {

        public IRepository<RegistrationRequest> RegistrationRequest {get;}

        void Commit();

        Task<int> CommitAsync();
        
    }
}
