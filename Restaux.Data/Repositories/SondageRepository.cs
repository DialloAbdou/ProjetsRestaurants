using Microsoft.EntityFrameworkCore;
using Restaux.Core.Models;
using Restaux.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Data.Repositories
{
    public class SondageRepository : Repository<Sondage>, ISondageRespository

    {
        private RestoDbContext RestoDbContext
        {
            get
            {
                return Context as RestoDbContext;
            }
        }
        public SondageRepository(RestoDbContext restoDbContext)
            : base(restoDbContext)
        {

        }
        public int CreateSondage()
        {
            var sondage = new Sondage { Date = DateTime.Now };
            RestoDbContext.Sondages.Add(sondage);
            return sondage.Id;

        }

        public async Task<IEnumerable<Sondage>> GetAllWithVotesAsync()
        {
            return await RestoDbContext
                   .Sondages
                   .Include(s => s.Votes)
                   .ToListAsync();
        }

        public async Task<Sondage> GetWithVoteByIdAsync(int id)
        {
            return await RestoDbContext
                   .Sondages
                   .Include(s => s.Votes).SingleOrDefaultAsync(s => s.Id == id);
        }

        public Task<IEnumerable<Resultat>> ObtenirLesResultats(int idSondage)
        {
            throw new NotImplementedException();
        }
    }
}
