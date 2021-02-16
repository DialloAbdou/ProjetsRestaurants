using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaux.Data.Configuration
{
    public class SondageConfiguration : IEntityTypeConfiguration<Sondage>
    {
        public void Configure(EntityTypeBuilder<Sondage> builder)
        {
            builder
                .HasKey(s => s.Id);
            builder
                .Property(s => s.Id)
                .UseIdentityColumn();

            builder.Property(s => s.Date)
                .IsRequired();
            builder
                .ToTable("Sondages");
        }
    }

    //builder
    //              .HasKey(a => a.Id);
    //        builder
    //            .Property(m => m.Id)
    //            .UseIdentityColumn();
    //builder
    //   .Property(m => m.Name)
    //           .IsRequired()
    //           .HasMaxLength(50);
    //builder
    //    .ToTable("Artists");
}
