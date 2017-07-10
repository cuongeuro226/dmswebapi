using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMWEB.Models;

namespace DMWEB.Services.Interfaces
{
    interface ICurrentLocationTrackingServices
    {
        Task<ObjectAPI> GetLocation(Guid nvID);
        Task<bool> UpdateLocation(CurrentLocationTracking clt);
    }
}
