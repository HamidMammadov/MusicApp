using Core.Models;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class AlbomRepository : Repository<Albom>, IAlbomRepository
    {
        private MusicAppDbContext _context => Context as MusicAppDbContext;

        public AlbomRepository(MusicAppDbContext context) : base(context) { }
    }
}
