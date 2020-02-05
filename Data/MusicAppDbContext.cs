using Core.Models;
using Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class MusicAppDbContext : DbContext
    {
        public MusicAppDbContext(DbContextOptions<MusicAppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ArtistConfigurations());
            builder.ApplyConfiguration(new AlbomConfigurations());
            builder.ApplyConfiguration(new MusicConfigurations());
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Albom> Alboms { get; set; }
        public DbSet<Music> Musics { get; set; }
    }
}
