using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Core.Repositories
{
    public interface IUtilisateurRepository : IRepository<Utilisateur>
    {
        Task<Utilisateur> Authentificate(string nom, string mpd);
        Task<IEnumerable<Utilisateur>> GetAllUtisateurAsync();
        Task<Utilisateur> GetUtilisateurAsync(int id);
        bool AdejatVoter(int idSondage, int idUtil);
        Task<Utilisateur> CreateUtillisateur(Utilisateur utilisateur, string mdp);
        void UpdateUtilisateur(Utilisateur utilisateur, string mdp = null);
        void DeleteUtilisateur(int id);

    }
}

