using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMWEB.Models;

namespace DMWEB.Services.Interfaces
{
    interface IChienDichServices
    {
        Task<IEnumerable<ChienDich>> GetListChienDich(Guid id);

        Task<IEnumerable<ChienDich>> GetListChienDich(DateTime start, DateTime end);

    }
}
