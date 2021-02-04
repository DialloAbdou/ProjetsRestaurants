using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Core.Repositories
{
    public interface IUtilisateurRepository : IRepository<Utilisateur>
    {
        Task<IEnumerable<Utilisateur>> GetAllUtisateurAsync();
        Task<Utilisateur> GetUtilisateurAsync(int id);

    }
}
