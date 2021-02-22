using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Core.Repositories
{
    public interface IVoteRespository : IRepository<Vote>
    {
        Task<IEnumerable<Vote>> GetAllVoteASync();
        Task<Vote> GetVoteByIdAsync(int id);
        Task AddVoteAsync(int idSondage, int idResto, int idUtilisateur);

    }
}
