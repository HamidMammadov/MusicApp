using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Data.Configurations
{
    class AlbomConfigurations : IEntityTypeConfiguration<Albom>
    {
        public void Configure(EntityTypeBuilder<Albom> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Id)
                .UseSqlServerIdentityColumn();

            builder
               .Property(m => m.Status)
               .IsRequired()
               .HasDefaultValue(true);

            builder
              .Property(m => m.ModifiedBy)
              .HasMaxLength(100);

            builder
               .Property(m => m.AddedBy)
               .HasMaxLength(100);

            builder
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(c => c.Poster)
                .IsRequired()
                .HasMaxLength(500);

            builder
                .Property(c => c.Desc)
                .IsRequired()
                .HasMaxLength(500);

            builder
                .HasOne(c => c.Artist)
                .WithMany(c => c.Alboms)
                .HasForeignKey(c => c.ArtistId);

            builder
                .ToTable("Alboms");
        }
    }
}
