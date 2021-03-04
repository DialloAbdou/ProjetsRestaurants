using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Restaux.Core.Models
{
    public class Sondage
    {
        public Sondage()
        {
            Votes = new Collection<Vote>();
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Vote> Votes { get; set; }  
    }
}
    