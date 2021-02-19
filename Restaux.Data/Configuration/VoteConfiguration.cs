using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaux.Data.Configuration
{
    public class VoteConfiguration : IEntityTypeConfiguration<Vote>
    {
        public void Configure(EntityTypeBuilder<Vote> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Id)
                .UseIdentityColumn();
            builder
                .HasOne(v => v.Utilisateur)
                .WithMany(v => v.Votes)
                .HasForeignKey(v => v.UtilisateurId);
            builder
               .HasOne(v => v.Sondage)
               .WithMany(v => v.Votes)
               .HasForeignKey(v => v.SondageId);
                
 

        }
    }
}
