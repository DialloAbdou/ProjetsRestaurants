using Restaux.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace Restaux.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUtilisateurRepository utilisateurs { get; }
        ISondageRespository sondages { get; }
        IVoteRespository votes { get; }
        IRestoRepository restos { get; }
        Task<int> CommitAsync();

    }
}
