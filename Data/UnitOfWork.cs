using Core;
using Core.Repositories;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UnitOfWork : IUnitOfWorks
    {
        private readonly MusicAppDbContext _context;
        private IArtistRepository _artistRepository;
        private IAlbomRepository _albomRepository;
        private IMusicRepository _musicRepository;

        public IArtistRepository Artist => _artistRepository ?? new ArtistRepository(_context);
        public IAlbomRepository Albom => _albomRepository ?? new AlbomRepository(_context);
        public IMusicRepository Music => _musicRepository ?? new MusicRepository(_context);

        public UnitOfWork(MusicAppDbContext context)
        {
            _context = context;
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
