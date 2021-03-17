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

        public async Task<Utilisateur> Authentificate(string nom, string mpd)
        {
            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(mpd))
                return null;
            var utilisateur = await RestoDbContext.Utilisateurs.FirstOrDefaultAsync(u => u.NomUtilisateur == nom);
            if (utilisateur == null) return null;
            if (!VerifyPasswordHash(mpd, utilisateur.PasswordHash, utilisateur.PasswordSalt)) return null;

            //// authentication successful
            return utilisateur;

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

        private static bool VerifyPasswordHash(string password,  byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException(password);
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("value cannot or whitespace only string");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytese)", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password sald (128 bytes expect).", "passwordHash");
            using(var hamac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hamac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for(int i =0; i< computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
               

            }
            return true;
        }

        //private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        //{
        //    if (password == null) throw new ArgumentNullException("password");
        //    if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
        //    if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
        //    if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

        //    using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
        //    {
        //        var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        //        for (int i = 0; i < computedHash.Length; i++)
        //        {
        //            if (computedHash[i] != storedHash[i]) return false;
        //        }
        //    }

        //    return true;
        //}
        //if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        //        return null;
        //    var user = await MyMusicDbContext.Users.SingleOrDefaultAsync(x => x.Username == username);
        //    if (user == null) return null;
        //    // check if password is correct
        //    if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
        //        return null;

        //    // authentication successful
        //    return user;

    }
}
