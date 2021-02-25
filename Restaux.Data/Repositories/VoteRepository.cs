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


            // Vote vote = new Vote
            // {
            //     Resto = bdd.Restos.First(r => r.Id == idResto),
            //     Utilisateur = bdd.Utilisateurs.First(u => u.Id == idUtilisateur)
            // };
            //Sondage sondage = bdd.Sondages.First(s => s.Id == idSondage);
            //if (sondage.Votes == null)
            //    sondage.Votes = new List<Vote>();
            //sondage.Votes.Add(vote);
            //bdd.SaveChanges()


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
    }
}
