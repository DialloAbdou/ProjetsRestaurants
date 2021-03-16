using Microsoft.EntityFrameworkCore;
using Restaux.Core.Models;
using Restaux.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
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
            : base(restoDbContext)
        {

        }

        public Task<Utilisateur> Authentificate(string nom, string mpd)
        {
            throw new NotImplementedException();
        }

        public Task<Utilisateur> CreateUtillisateur(Utilisateur utilisateur, string mdp)
        {
            throw new NotImplementedException();
        }

        public Task<Utilisateur> GetUtilisateurByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Utilisateur> GetUtilisateurWithVoteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUtilisateur(Utilisateur utilisateur, string mdp = null)
        {
            throw new NotImplementedException();
        }

        public void DeleteUtilisateur(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Utilisateur>> GetAllUtilisateur()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Utilisateur>> GetAllWithVotesAsync()
        {
            throw new NotImplementedException();
        }

        //public async Task<Utilisateur> Authentificate(string nom, string mdp)
        //{
        //    return await RestoDbContext 
        //                 .Utilisateurs
        //                 .FirstOrDefaultAsync(u => u.Prenom == nom && u.MotDePasse == mdp);
        //}

        ///*
        // * *
        // * **/

        //public async Task<Utilisateur> CreateUtillisateur(Utilisateur utilisateur, string mdp)
        //{
        //    throw new NotImplementedException();
        //}

        //public void UpdateUtilisateur(Utilisateur utilisateur, string mdp = null)
        //{
        //    var user = RestoDbContext.Utilisateurs.Find(utilisateur.Id);
        //    if (user == null) throw new Exception("utilisateur n'existe pas");
        //    if(utilisateur.Prenom != user.Prenom)
        //    {
        //        if (RestoDbContext.Utilisateurs.Any(u => u.Prenom == utilisateur.Prenom))
        //            throw new Exception("Utisateur " + utilisateur.Prenom + " il est tjs prise");
        //    }

        //    user.Prenom = utilisateur.Prenom;
        //    user.MotDePasse = mdp;
        //    RestoDbContext.Utilisateurs.Update(user);

        //    // === Voir la suite Apres===


        //}

        //public void DeleteUtilisateur(int id)
        //{
        //    var user = RestoDbContext.Utilisateurs.FirstOrDefault(u => u.Id == id);
        //    if (user == null) throw new Exception("utilisateur n'existe pas");
        //    RestoDbContext.Utilisateurs.Remove(user);
        //}

        //public async Task<Utilisateur> GetUtilisateurByIdAsync(int id)
        //{
        //    return await RestoDbContext
        //        .Utilisateurs
        //        .SingleOrDefaultAsync(u => u.Id == id);
        //}

        //public async Task<Utilisateur> GetUtilisateurWithVoteByIdAsync(int id)
        //{
        //    return await RestoDbContext
        //        .Utilisateurs
        //        .Include(u => u.Votes)
        //        .SingleOrDefaultAsync(u => u.Id == id);
        //}

        //public async Task<IEnumerable<Utilisateur>> GetAllUtilisateur()
        //{
        //    return await RestoDbContext
        //                 .Utilisateurs.ToListAsync();
        //}

        //public async Task<IEnumerable<Utilisateur>> GetAllWithVotesAsync()
        //{
        //    return await RestoDbContext
        //                 .Utilisateurs.Include(u => u.Votes).ToListAsync();
        //}
    }
}
