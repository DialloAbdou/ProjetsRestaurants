using Microsoft.EntityFrameworkCore;
using Restaux.Core.Models;
using Restaux.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Data.Repositories
{
    public class RestoRepository : Repository<Resto>, IRestoRepository
    {
        private RestoDbContext RestoDbContext {
            get { return Context as RestoDbContext; }
        }
        public RestoRepository(RestoDbContext restoDbContext) : base(restoDbContext)
        {
            

        }
        public async Task<IEnumerable<Resto>> GetAllWithVotesAsync()
        {
            return await RestoDbContext.Restos.Include(r => r.Votes).ToListAsync();
        }

        public async Task<Resto> GetWithVoteByIdAsync(int id)
        {
            return await RestoDbContext
                         .Restos
                         .Include(r => r.Votes)
                         .SingleOrDefaultAsync(r => r.Id == id);
        }

        public async Task<bool> RestaurantExist(string nom)
        {
            return await RestoDbContext.Restos.AnyAsync(r => r.Nom == nom);
        }

        public async Task<IEnumerable<Resto>> GetAllWithUtilisateurAsync()
        {
            return await RestoDbContext
                      .Restos
                      .Include(r => r.Utilisateur)
                      .ToListAsync();
        }

        public async Task<IEnumerable<Resto>> GetAllWithUtilisateurByIdAsync(int idUt)
        {
            return await RestoDbContext.Restos
                .Include(r => r.Utilisateur)
                .Where(r => r.utilisateurId == idUt)
                .ToListAsync();
        }
    }
}
