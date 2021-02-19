using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Restaux.Core.Models
{
    public class Resto
    {
        public Resto()
        {
            Votes = new Collection<Vote>();
        }
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Telephone { get; set; }
        public ICollection<Vote> Votes { get; set; }
    }
}
    