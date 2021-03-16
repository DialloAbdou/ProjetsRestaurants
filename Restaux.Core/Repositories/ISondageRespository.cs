using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Core.Repositories
{
    public interface ISondageRespository : IRepository<Sondage>
    {
        Task<IEnumerable<Sondage>> GetAllWithVotesAsync();
        Task<Sondage> GetWithVoteByIdAsync(int id);
        int CreateSondage();
  
    }
}
