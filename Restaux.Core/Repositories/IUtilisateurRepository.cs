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
        Task<Utilisateur> CreateUtillisateur(Utilisateur utilisateur, string mdp);
        Task<Utilisateur> GetUtilisateurByIdAsync(int id);
        Task<Utilisateur> GetUtilisateurWithVoteByIdAsync(int id);
        void UpdateUtilisateur(Utilisateur utilisateur, string mdp = null);
        void DeleteUtilisateur(int id);
        Task<IEnumerable<Utilisateur>> GetAllUtilisateur();
        Task<IEnumerable<Utilisateur>> GetAllWithVotesAsync();


    }


}

