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
        private readonly IUnitOfWork _UnitOfWork;

        public RestoService(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        public async Task<Resto> CreateResto(Resto resto)
        {
            await _UnitOfWork.Restos.AddAsync(resto);
            await _UnitOfWork.CommitAsync();
            return resto;
        }

        public async Task DeleteResto(Resto resto)
        {
            _UnitOfWork.Restos.Remove(resto);
            await _UnitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Resto>> GetAllArtist()
        {
            return await _UnitOfWork.Restos.GetAllAsync();
        }

        public async Task<Resto> GetRestoById(int id)
        {
            return await _UnitOfWork.Restos.GetByIdAsync(id);
        }

        public async Task UpdateResto(Resto restoUpdate, Resto resto)
        {
            restoUpdate.Nom = resto.Nom;
            restoUpdate.Telephone = resto.Telephone;
            await _UnitOfWork.CommitAsync();
        }
    }
}
