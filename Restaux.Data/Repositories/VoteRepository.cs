using Microsoft.EntityFrameworkCore;
using Restaux.Core.Models;
using Restaux.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

        public async Task AddVoteAsync(int idSondage, int idResto, int idUtilisateur)
        {
            Vote vote = new Vote
            {
                Resto = await RestoDbContext.Restos.FirstOrDefaultAsync(r => r.Id == idResto),
                Utilisateur = await RestoDbContext.Utilisateurs.FirstOrDefaultAsync(u => u.Id == idUtilisateur),
            };
            Sondage sondage = await RestoDbContext.Sondages.SingleOrDefaultAsync(s => s.Id == idSondage);
            if (sondage == null)
                sondage.Votes = new Collection<Vote>();
            sondage.Votes.Add(vote);
        }

        public bool AdejatVoter(int idSondage, int idUtil)
        {
            var sondage = RestoDbContext.Sondages.FirstOrDefault(s => s.Id == idSondage);
            if(sondage == null)
            {
                return false;
            }
            else
            {
                return sondage.Votes.Any(u => u.Utilisateur.Id == idUtil);
            }
        }

        public async Task<IEnumerable<Resultat>> ObtenirLesResultats(int idSondage)
        {
            var restaurants = await RestoDbContext.Restos.ToListAsync();
            var resultats = new List<Resultat>();
            Sondage sondage = await RestoDbContext.Sondages.FirstAsync(s => s.Id == idSondage);
            foreach(IGrouping<int,Vote>grouping in sondage.Votes.GroupBy(v=>v.Resto.Id))
            {
                int idRestaurant = grouping.Key;
                Resto resto = restaurants.First(r => r.Id == idRestaurant);
                int nmbreVotes = grouping.Count();
                resultats.Add(new Resultat { Nom = resto.Nom, Telephone = resto.Telephone, NombreDeVotes = nmbreVotes });
            }
            return resultats;
        }
    }
}
