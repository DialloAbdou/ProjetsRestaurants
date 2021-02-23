using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Core.services
{
     public interface ISondageService
    {
        Task<IEnumerable<Sondage>> GetAll();
        Task<Sondage> GetSondage(int id);
        Task<Int32> CreateSondage();
        Task<IEnumerable<Resultat>> ObtenirLesResultats(int idSondage);

     }
}
    