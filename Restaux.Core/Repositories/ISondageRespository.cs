using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Core.Repositories
{
    public interface ISondageRespository : IRepository<Sondage>
    {
        Task<IEnumerable<Sondage>> GetAllSondageAsync();
        Task<Sondage> GetSondageByIdAsync(int id);
        Task<Int32> CreateSondageAsync();
        Task<IEnumerable<Resultat>>ObtenirLesResultats(int idSondage);

    }
}
