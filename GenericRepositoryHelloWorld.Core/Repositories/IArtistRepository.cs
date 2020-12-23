using GenericRepositoryHelloWorld.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenericRepositoryHelloWorld.Core.Repositories
{
    public interface IArtistRepository : IRepository<Artist>
    {
        Task<IEnumerable<Artist>> GetAllWithMusicsAsync();
        Task<Artist> GetWithMusicsByIdAsync(int id);
    }
}
