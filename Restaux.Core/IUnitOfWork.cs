using Restaux.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace Restaux.Core
{
    public interface IUnitOfWork : IDisposable
    {

        IUtilisateurRepository Utilisateurs { get; }

        ISondageRespository Sondages { get; }

        IVoteRespository Votes { get; }

        IRestoRepository Restos { get; }

        Task<int> CommitAsync();

    }
}
