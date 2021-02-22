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
            Restos = new Collection<Resto>();
        }
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string MotDePasse { get; set; }

        public ICollection<Resto> Restos { get; set; }

    }
}
