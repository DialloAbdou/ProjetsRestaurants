using System;
using System.Collections.Generic;
using System.Text;

namespace Restaux.Core.Models
{
    public class Sondage
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Vote> Votes { get; set; }

    }
}
