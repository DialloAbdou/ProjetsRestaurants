using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Core.services
{
    /*
     * la Couche service est la couche centrale de notre architecture, elle fait lien entre 
     * la couche API et la couche Dal
     * 
     * **/
    public interface IRestoService
    {
        Task<Resto> GetRestoById(int id);
        Task<IEnumerable<Resto>> GetAllArtist(); 
        Task<Resto> CreateResto(Resto resto);
        Task UpdateResto(Resto restoUpdate, Resto resto);
        Task DeleteResto(Resto resto);
    }

}
