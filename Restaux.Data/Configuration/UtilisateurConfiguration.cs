using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaux.Data.Configuration
{
    public class UtilisateurConfiguration : IEntityTypeConfiguration<Utilisateur>
    {
        public void Configure(EntityTypeBuilder<Utilisateur> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id)
                .UseIdentityColumn();
            builder.Property(u=> u.Prenom)
                .IsRequired()
                .HasMaxLength(30);
            builder.Property(u => u.MotDePasse)
                .IsRequired()
                .HasMaxLength(8);
         
            builder.ToTable("Utilisateurs");
        }
    }
}

