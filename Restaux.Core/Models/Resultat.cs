using System;
using System.Collections.Generic;
using System.Text;

namespace Restaux.Core.Models
{
        /*
        *  Cette indique le nom de restaure et son tele aussi nbre de votant
        */
    public class Resultat
    {
       
        public string Nom { get; set; }
        public string Telephone { get; set; }
        public int NombreDeVotes { get; set; }
    }
}
