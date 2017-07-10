using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using DMWEB.Models;
using DMWEB.Services.Interfaces;

namespace DMWEB.Services.Implements
{
    public class ChienDichServices : IChienDichServices
    {
        private DMSContext db = new DMSContext();
        public async Task<IEnumerable<ChienDich>> GetListChienDich(Guid id)
        {
            return await db.ChienDiches.Where(n => n.ID.Equals(id)).ToListAsync();
        }

        public async Task<IEnumerable<ChienDich>> GetListChienDich(DateTime start, DateTime end)
        {
            if (start != null && end != null)
            {

                return await db.ChienDiches.Where(n => n.NgayBD.Value.CompareTo(start) >= 0 && 
                n.NgayKT.Value.CompareTo(end) <= 0
                ).ToListAsync();
            }
            return new List<ChienDich>();
        }
    }
}