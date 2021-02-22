using System;
using System.Collections.Generic;
using System.Text;

namespace Restaux.Core.Models
{
    public class Vote
    {
        
        public int Id { get; set; }
 
        public Sondage Sondage { get; set; }
        public int SondageId { get; set; }
        public Resto Resto { get; set; }
        public int RestoId { get; set; }


    }
}
