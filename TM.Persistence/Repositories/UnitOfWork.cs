using TM.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly TMDbContext _context;

        
        private ITasksRepository _tasksRepository;
        private ICheckListRepository _checklistRepository;

       
        public UnitOfWork(TMDbContext context)
        {
            _context = context;
        }

        

        public ITasksRepository TasksRepository
        {
            get
            {
                if (_tasksRepository == null)
                    _tasksRepository = new TasksRepository(_context);
                return _tasksRepository;
            }
        }
        
        
        public ICheckListRepository CheckListRepository
        {
            get
            {
                if (_checklistRepository == null)
                    _checklistRepository = new CheckListRepository(_context);
                return _checklistRepository;
            }
        }


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
