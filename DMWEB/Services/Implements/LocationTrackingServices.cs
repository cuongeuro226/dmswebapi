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
    public class LocationTrackingServices : ILocationTrackingServices
    {

        DMSContext db= new DMSContext();


        public async Task<bool> UpdateLocation(Location_Tracking location)
        {
            bool rel = true;


            if (location != null)
            {
                var local = await db.Location_Tracking
                    .Where(n => n.NVID.Equals(location.NVID) && int.Parse(n.GioBD) < DateTime.Now.Hour &&
                                int.Parse(n.GioKT) > DateTime.Now.Hour && n.DateTracking.Value.Date.ToString("d").Equals(DateTime.Now.Date.ToString("d"))).FirstOrDefaultAsync();

                if (local == null)
                {
                    location.GioBD = DateTime.Now.Hour.ToString();
                    location.GioKT = (DateTime.Now.Hour + 1).ToString();
                    location.NguoiTao = location.NVID.ToString();
                    location.NgayTao = DateTime.Now;
                    location.DateTracking = DateTime.Now;
                    db.Location_Tracking.Add(location);
                    await db.SaveChangesAsync();
                }
                else
                {
                    local.NgaySua = DateTime.Now;
                    local.NguoiSua = location.NVID.ToString();
                    local.GhiChu = location.GhiChu;
                    db.Entry(local).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                }
            }
            else
            {
                rel = false;
            }
            
            return rel;
        }

        public async Task<IEnumerable<Location_Tracking>> GetList(Guid id)
        {
            List<Location_Tracking> list = new List<Location_Tracking>();

            list = await db.Location_Tracking.Where(n => n.NVID.Equals(id)).ToListAsync();

            return list;
        }

        internal Task GetList(DateTime? dateTracking)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Location_Tracking>> GetList(DateTime date)
        {
            List<Location_Tracking> list = new List<Location_Tracking>();

            list = await db.Location_Tracking.Where(n => n.DateTracking.Value.ToString("d").Equals(date.ToString("d"))).ToListAsync();

            return list;
        }
    }
}