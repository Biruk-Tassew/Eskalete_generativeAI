namespace TM.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        ITasksRepository TasksRepository{get;}
        ICheckListRepository CheckListRepository{get;}
        IUserRepository UserRepository {get;}
        

        Task<int> Save();
         
    }
}