using Restaux.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace Restaux.Core
{
    public interface IUnitOfWork : IDisposable
    {

        IUtilisateurRepository Utilisateurs { get; }
        IRestoRepository Restos { get; }
        IVoteRespository Votes { get; }
        ISondageRespository Sondages { get; }
        Task<int> CommitAsync();

    }
}
