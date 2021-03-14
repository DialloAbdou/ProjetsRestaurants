using Restaux.Core;
using Restaux.Core.Models;
using Restaux.Core.services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Services.Services
{
     public class VoteService : IVoteService
    {
        private readonly IUnitOfWork _unitOfWork;

        public VoteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        /****/
        public async Task<IEnumerable<Vote>> GetAllVote()
        {
            return await _unitOfWork.Votes.GetAllAsync();
           
        }

        public async Task<Vote> GetVoteById(int id)
        {
            return await _unitOfWork.Votes.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Resultat>> ObtenirLesResultats(int idSondage)
        {
            return await _unitOfWork.Votes.ObtenirLesResultats(idSondage);
        }
    }
}
