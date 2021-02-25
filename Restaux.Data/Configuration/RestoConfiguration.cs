using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaux.Data.Configuration
{
    public class RestoConfiguration : IEntityTypeConfiguration<Resto>
    { 
        public void Configure(EntityTypeBuilder<Resto> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id)
                .UseIdentityColumn();
            builder.Property(r => r.Nom)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(r => r.Telephone)
                .IsRequired()
                .HasMaxLength(10);
            builder.ToTable("Restos");
        
        }
    }
}
