using System;
using System.Collections.Generic;
using System.Text;

namespace Restaux.Core.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        public int UtilisateurId { get; set; }
        public virtual Resto Resto { get; set; }
        public int RestoId { get; set; }
        public Sondage Sondage { get; set; }
        public int SondageId { get; set; }

    }
}
