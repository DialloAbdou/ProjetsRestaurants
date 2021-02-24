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
        public string Prenom { get; set; }
        public string MotDePasse { get; set; }
        public ICollection<Vote> Votes { get; set; }

    }
}
