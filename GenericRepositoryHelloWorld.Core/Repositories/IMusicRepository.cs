using GenericRepositoryHelloWorld.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenericRepositoryHelloWorld.Core.Repositories
{
    public interface IMusicRepository : IRepository<Music>
    {
        Task<IEnumerable<Music>> GetAllWithArtistAsync();
        Task<Music> GetWithArtistByIdAsync(int id);
        Task<IEnumerable<Music>> GetAllWithArtistByArtistIdAsync(int artistId);
    }
}
