using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Core.Repositories
{
    public interface IComposerRepository
    {
        Task<IEnumerable<Composer>> GetAllComposer();
        Task<Composer> GetComposerById(string id);
        Task<Composer> Create(Composer composer);
        Task<bool> Delete(string id);
        void  Update(string id, Composer composer);
    }
}
