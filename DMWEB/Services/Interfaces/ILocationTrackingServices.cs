using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMWEB.Models;

namespace DMWEB.Services.Interfaces
{
    interface ILocationTrackingServices
    {
        Task<bool> UpdateLocation(Location_Tracking location);
        Task<IEnumerable<Location_Tracking>> GetList(Guid id);

        Task<IEnumerable<Location_Tracking>> GetList(DateTime date);
    }
}
