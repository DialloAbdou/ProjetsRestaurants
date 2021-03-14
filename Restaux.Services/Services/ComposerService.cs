using Restaux.Core.Models;
using Restaux.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Services.Services
{
    public class ComposerService : IComposerRepository
    {
        private readonly IComposerRepository _context;
        public ComposerService(IComposerRepository  Context)
        {
            _context = Context;
        }

        public async Task<Composer> Create(Composer composer)
        {
            return await _context.Create(composer);
        }

        public async Task<bool> Delete(string id)
        {
            return await _context.Delete(id);
        }

        public async Task<IEnumerable<Composer>> GetAllComposer()
        {
            return await _context.GetAllComposer();

        }

        public async Task<Composer> GetComposerById(string id)
        {
            return await _context.GetComposerById(id);

        }

        public void Update(string id, Composer composer)
        {
            _context.Update(id, composer);
        }
    }
}
