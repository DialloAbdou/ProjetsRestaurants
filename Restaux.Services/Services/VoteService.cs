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

            public async Task AddVote(int idSondage, int idResto, int idUtilisateur)
            {
                   _unitOfWork.Votes.
            }

        public bool AdejatVoter(int idSondage, int idUtil)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vote>> GetAllVote()
        {
            throw new NotImplementedException();
        }

        public Task<Vote> GetVoteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Resultat>> ObtenirLesResultats(int idSondage)
        {
            throw new NotImplementedException();
        }
    }
}
