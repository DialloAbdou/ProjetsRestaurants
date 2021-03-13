using Restaux.Core;
using Restaux.Core.Models;
using Restaux.Core.services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Services.Services
{
    public class RestoService : IRestoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RestoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Resto> CreateResto(Resto resto)
        {
            await _unitOfWork.Restos.AddAsync(resto);
            return resto;
        }

        public async Task DeleteResto(Resto resto)
        {
            _unitOfWork.Restos.Remove(resto);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Resto>> GetAllArtist()
        {
            return await _unitOfWork.Restos.GetAllAsync();
        }

        public async Task<Resto> GetRestoById(int id)
        {
            return await _unitOfWork.Restos.GetByIdAsync(id);
        }

        public async Task UpdateResto(Resto restoUpdate, Resto resto)
        {
            restoUpdate.Nom = resto.Nom;
            restoUpdate.Telephone = resto.Telephone;
            _unitOfWork.Restos.Update(restoUpdate);
            await _unitOfWork.CommitAsync();

        }
    }
}
