using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Core.Repositories
{
    public interface IRestoRepository : IRepository<Resto>
    {
        Task<IEnumerable<Resto>> GetAllRestoAsync();
        Task<Resto> GetRestoByIdAsync(int id);
        bool RestaurantExist(string nom);      




        
    }
}
