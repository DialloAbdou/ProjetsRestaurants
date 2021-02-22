using Microsoft.EntityFrameworkCore;
using Restaux.Core.Models;
using Restaux.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Data.Repositories
{
    public class UtilisateurRepository : Repository<Utilisateur>, IUtilisateurRepository
    {

        private RestoDbContext RestoDbContext
        {
            get
            {
                return Context as RestoDbContext;
            }
        }
        public UtilisateurRepository(RestoDbContext restoDbContext)
            :base(restoDbContext)
        {

        }
        public async Task<IEnumerable<Utilisateur>> GetAllUtisateurAsync()
        {
            return await RestoDbContext.Utilisateurs.ToListAsync();
        }

        public async Task<Utilisateur> GetUtilisateurAsync(int id)
        {
            return await RestoDbContext.Utilisateurs.SingleOrDefaultAsync(u => u.Id == id);
        }

        public Task<Utilisateur> Authentificate(string nom, string mpd)
        {
            throw new NotImplementedException();
        }

        public bool AdejatVoter(int idSondage, int idUtil)
        {
            throw new NotImplementedException();
        }
    }
}
