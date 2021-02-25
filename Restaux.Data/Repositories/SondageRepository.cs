using Microsoft.EntityFrameworkCore;
using Restaux.Core.Models;
using Restaux.Core.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public async Task<IEnumerable<Resultat>> ObtenirLesResultats(int idSondage)
        {
            ///ICollection<Resultat> resultats = new Collection<Resultat>();
            throw new NotImplementedException();
        }


        //    List<Resto> restaurants = ObtientTousLesRestaurants();
        //    List<Resultats> resultats = new List<Resultats>();
        //    Sondage sondage = bdd.Sondages.First(s => s.Id == idSondage);
        //    foreach (IGrouping<int, Vote> grouping in sondage.Votes.GroupBy(v => v.Resto.Id))
        //    {
        //        int idRestaurant = grouping.Key;
        //    Resto resto = restaurants.First(r => r.Id == idRestaurant);
        //    int nombreDeVotes = grouping.Count();
        //    resultats.Add(new Resultats { Nom = resto.Nom, Telephone = resto.Telephone, NombreDeVotes = nombreDeVotes
        //});
        //    }
        //    return resultats;
    }
}
