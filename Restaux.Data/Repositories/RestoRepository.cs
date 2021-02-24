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
        private RestoDbContext RestoDbContext
        {
            get { return Context as RestoDbContext; }
        }
        public RestoRepository(RestoDbContext restoDbContext) : base(restoDbContext)
        {


        }
        /*
         * La Liste de Tous les Restaurants Qui participé à la vote *
         */
        public async Task<IEnumerable<Resto>> GetAllWithVotesAsync()
        {
            return await RestoDbContext.Restos.Include(r => r.Votes).ToListAsync();
        }

        /**
         * Renvoie Un Restaurants qui a participe à la vote
         * **/
        public async Task<Resto> GetWithVoteByIdAsync(int id)
        {
            return await RestoDbContext
                         .Restos
                         .Include(r => r.Votes)
                         .SingleOrDefaultAsync(r => r.Id == id);
        }

        /*** 
         * Verifier l'existance d'un restaurant*
         */
        public async Task<bool> RestaurantExist(string nom)
        {
            return await RestoDbContext.Restos.AnyAsync(r => r.Nom == nom);
        }


    }
}
