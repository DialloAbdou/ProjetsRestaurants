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
        private readonly IUnitOfWork _unitOfWork;

        public SondageService( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> CreateSondage()
        {
            var sondage = new Sondage { Date = DateTime.Now };
            _unitOfWork.Sondages.CreateSondage();
            await _unitOfWork.CommitAsync();
            return sondage.Id;
        }

        public async Task<IEnumerable<Sondage>> GetAll()
        {
            return await _unitOfWork.Sondages.GetAllAsync();
        }

        public async Task<Sondage> GetSondage(int id)
        {
            return await _unitOfWork.Sondages.GetWithVoteByIdAsync(id);

        }
    }
}
