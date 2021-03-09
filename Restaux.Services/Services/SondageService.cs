using Restaux.Core;
using Restaux.Core.Models;
using Restaux.Core.services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Services.Services
{
    public class SondageService : ISondageService
    {
        private readonly IUnitOfWork _UnitOfWork;

        public SondageService(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        public async Task<int> CreateSondage()
        {
            var sondage = new Sondage { Date = DateTime.Now };
            await _UnitOfWork.Sondages.AddAsync(sondage);
            await _UnitOfWork.CommitAsync();
            return sondage.Id;
        }

        public async Task<IEnumerable<Sondage>> GetAll()
        {
            return await _UnitOfWork.Sondages.GetAllAsync();
        }

        public Task<Sondage> GetSondage(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Resultat>> ObtenirLesResultats(int idSondage)
        {
            throw new NotImplementedException();
        }
    }
}
