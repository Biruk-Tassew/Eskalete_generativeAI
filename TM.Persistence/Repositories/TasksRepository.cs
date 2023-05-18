using TM.Application.Contracts.Persistence;
using TM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM.Persistence.Repositories
{
    public class TasksRepository : GenericRepository<Tasks>, ITasksRepository
    {
        private readonly TMDbContext _context;
        public TasksRepository(TMDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
    }
}
