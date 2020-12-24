using GenericRepositoryHelloWorld.Core.Models;
using GenericRepositoryHelloWorld.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryHelloWorld.Data.Repositories
{
    public class MusicRepository : Repository<Music>, IMusicRepository
    {
        public MusicRepository(MusicMarketDbContext context)
             : base(context)
        { }

        public async Task<IEnumerable<Music>> GetAllWithArtistAsync()
        {
            return await musicMarketDbContext.Musics
                .Include(a => a.Artist)
                .ToListAsync();
        }

        public async Task<Music> GetWithArtistByIdAsync(int id)
        {
            return await musicMarketDbContext.Musics
                .Include(x => x.Artist)
                .SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Music>> GetAllWithArtistByArtistIdAsync(int artistId)
        {
            return await musicMarketDbContext.Musics
                .Include(x => x.Artist)
                .Where(x => x.ArtistId == artistId)
                .ToListAsync();
        }

        private MusicMarketDbContext musicMarketDbContext
        {
            get { return Context as MusicMarketDbContext; }
        }
    }
}
