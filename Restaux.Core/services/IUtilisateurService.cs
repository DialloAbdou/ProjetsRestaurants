using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Core.services
{
    public interface IUtilisateurService
    {
        Task<IEnumerable<Utilisateur>> GetAllUtilisateur();
        Task<Utilisateur> GetUtilisateurById(int id);
        Task<Utilisateur> CreateUtillisateur(Utilisateur utilisateur, string mdp);
        void UpdateUtilisateur(Utilisateur utilisateur, string mdp = null);
        void DeleteUtilisateur(int id);

    }
}

