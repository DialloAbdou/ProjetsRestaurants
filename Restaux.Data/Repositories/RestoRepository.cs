using Microsoft.EntityFrameworkCore;
using Restaux.Core.Models;
using Restaux.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Data.Repositories
{
    public class RestoRepository : Repository<Resto>, IRestoRepository
    {
        private RestoDbContext RestoDbContext {
            get { return Context as RestoDbContext; }
        }
        public RestoRepository(RestoDbContext restoDbContext) : base(restoDbContext)
        {
            

        }
        public async Task<IEnumerable<Resto>> GetAllRestoAsync()
        {
            return await RestoDbContext.Restos.ToListAsync();
        }

        public async Task<Resto> GetRestoByIdAsync(int id)
        {
            return await RestoDbContext.Restos.FirstOrDefaultAsync(r => r.Id == id);
        }

        public bool RestaurantExist(string nom)
        {
            throw new NotImplementedException();
        }
    }
}
