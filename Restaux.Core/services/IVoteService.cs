using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Core.services
{
    public interface IVoteService
    {
        Task<IEnumerable<Vote>> GetAllVote();
        Task<Vote> GetVoteById(int id);
        Task AddVote(int idSondage, int idResto, int idUtilisateur);
        bool AdejatVoter(int idSondage, int idUtil);
        Task<IEnumerable<Resultat>> ObtenirLesResultats(int idSondage);
    }
}
