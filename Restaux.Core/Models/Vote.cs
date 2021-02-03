﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaux.Core.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        public virtual Resto Resto { get; set; }

    }
}