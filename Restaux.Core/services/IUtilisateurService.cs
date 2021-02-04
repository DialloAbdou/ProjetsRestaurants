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
        Task AddUtilisateur(Utilisateur utilisateur);
        Task updateUtilisateur(Utilisateur utilisateurUpdate, Utilisateur utilisateur);

    }
}

