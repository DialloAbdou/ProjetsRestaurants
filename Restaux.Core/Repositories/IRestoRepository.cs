using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Core.Repositories
{
    public interface IRestoRepository : IRepository<Resto>
    {
        Task<IEnumerable<Resto>> GetAllWithVotesAsync();
        Task<IEnumerable<Resto>> GetAllWithUtilisateurAsync();
        Task<IEnumerable<Resto>> GetAllWithUtilisateurByIdAsync(int idUt);


        Task<Resto> GetWithVoteByIdAsync(int id);
      Task<bool> RestaurantExist(string nom);
    }
}
