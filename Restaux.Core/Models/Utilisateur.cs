using System;
using System.Collections.Generic;
using System.Text;

namespace Restaux.Core.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string MotDePasse { get; set; }
        public ICollection<Vote> Votes { get; set; }


    }
}
