using GenericRepositoryHelloWorld.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenericRepositoryHelloWorld.Core.Services
{
    public interface IArtistService
    {
        Task<IEnumerable<Artist>> GetAllArtists();
        Task<Artist> GetArtistById(int id);
        Task<Artist> CreateArtist(Artist artist);
        Task<Artist> UpdateArtist(Artist updatedArtist,Artist artist);
        Task<Artist> DeleteArtist(Artist artist);
    }
}
