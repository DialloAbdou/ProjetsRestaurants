using Restaux.Core;
using Restaux.Core.Repositories;
using Restaux.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private RestoDbContext _context;
        private IUtilisateurRepository _utilisateurRepository;
        private IRestoRepository _restoRepository;  

        public UnitOfWork( RestoDbContext context)
        {
            _context = context;
        }

        public IUtilisateurRepository Utilisateurs => _utilisateurRepository = _utilisateurRepository ?? new UtilisateurRepository(_context);
        public IRestoRepository Restos => _restoRepository = _restoRepository ?? new RestoRepository(_context);

        public async Task<int> CommitAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
