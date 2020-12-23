using GenericRepositoryHelloWorld.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryHelloWorld.Core.Services
{
    public interface IMusicServices
    {
        Task<IEnumerable<Music>> GetAllWithArtist();
        Task<Music> GetMusicById(int id);
        Task<IEnumerable<Music>> GetMusicsByArtistId(int artistId);
        Task<Music> CreateMusic(Music newMusic);
        Task UpdateMusic(Music updatedMusic,Music music);
        Task DeleteMusic(Music music);
    }
}
