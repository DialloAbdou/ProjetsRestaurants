using Microsoft.EntityFrameworkCore;
using Restaux.Core.Models;
using Restaux.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Data.Repositories
{
    public class VoteRepository: Repository<Vote>, IVoteRespository
    {
        private RestoDbContext RestoDbContext
        {
            get
            {
                 return Context as RestoDbContext;
            }
        }

        public VoteRepository(RestoDbContext restoDbContext) : base(restoDbContext)
        {

        }

        public async Task<IEnumerable<Vote>> GetAllVoteASync()
        {
            return await RestoDbContext.Votes.ToListAsync();    

        }

        public async Task<Vote> GetVoteByIdAsync(int id)
        {
            return await RestoDbContext.Votes.FirstOrDefaultAsync(v => v.Id == id);
        }

     
    }
}
