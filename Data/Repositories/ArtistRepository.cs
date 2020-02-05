using Core.Models;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        private MusicAppDbContext _context => Context as MusicAppDbContext;

        public ArtistRepository(MusicAppDbContext context) : base(context) { }
    }
}
