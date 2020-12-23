using GenericRepositoryHelloWorld.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace GenericRepositoryHelloWorld.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IMusicRepository Musics { get; }
        IArtistRepository Artists { get; }
        Task<int> CommitAsync();
    }
}
