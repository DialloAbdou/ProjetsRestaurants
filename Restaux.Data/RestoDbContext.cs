using Microsoft.EntityFrameworkCore;
using Restaux.Core.Models;
using Restaux.Data.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaux.Data
{
    public class RestoDbContext : DbContext
    {
        public DbSet<Resto> Restos{ get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public RestoDbContext(DbContextOptions<RestoDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new RestoConfiguration());
            builder.ApplyConfiguration(new UtilisateurConfiguration());
        }



    }
}
