using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    class MusicConfigurations : IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Music> builder)
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
                .Property(c => c.File)
                .IsRequired()
                .HasMaxLength(500);

            builder
                .Property(c => c.ListenCount)
                .IsRequired()
                .HasDefaultValue(0);

            builder
                .Property(c => c.CanDownload)
                .IsRequired()
                .HasDefaultValue(false);

            builder
                .HasOne(c => c.Albom)
                .WithMany(c => c.Musics)
                .HasForeignKey(c => c.AlbomId);

            builder
                .ToTable("Musics");
        }
    }
}
