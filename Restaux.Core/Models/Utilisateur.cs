using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Restaux.Core.Models
{
    public class Utilisateur
    {

        public Utilisateur()
        {
            Votes = new Collection<Vote>();
        }
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NomUtilisateur { get; set; }
        public ICollection<Vote> Votes { get; set;}
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public bool IsAdmin { get; set; }


    }
}
