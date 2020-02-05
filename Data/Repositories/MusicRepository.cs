using Core.Models;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class MusicRepository : Repository<Music>, IMusicRepository
    {
        private MusicAppDbContext _context => Context as MusicAppDbContext;

        public MusicRepository(MusicAppDbContext context) : base(context) { }
    }
}
