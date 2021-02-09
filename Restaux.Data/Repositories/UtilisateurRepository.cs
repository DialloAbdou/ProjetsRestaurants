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
        public UtilisateurRepository()
        {

        }
        public Task<IEnumerable<Utilisateur>> GetAllUtisateurAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Utilisateur> GetUtilisateurAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
