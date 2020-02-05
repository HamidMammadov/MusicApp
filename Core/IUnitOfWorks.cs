using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IUnitOfWorks
    {
        IArtistRepository Artist { get; }
        IAlbomRepository Albom { get; }
        IMusicRepository Music { get; }
        Task<int> CommitAsync();
    }
}
