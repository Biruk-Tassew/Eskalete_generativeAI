
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TM.Application.Contracts.Persistence;
using TM.Domain;
using TM.Persistence.Repositories;

namespace TM.Persistence.Repositories
{
    public class CheckListRepository : GenericRepository<CheckList>, ICheckListRepository
    {
        private readonly TMDbContext _context;
        public CheckListRepository(TMDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
    }
}
