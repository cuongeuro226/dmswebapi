using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DMWEB.Models;
using DMWEB.Services.Interfaces;

namespace DMWEB.Services.Implements
{
    public class CurrentLocaitonTrackingServices : ICurrentLocationTrackingServices
    {
        DMSContext db=  new DMSContext();
        /// <summary>
        /// Get vị trị hiện tại của nhân viên
        /// </summary>
        /// <param name="nvID"></param>
        /// <returns></returns>
        public async Task<ObjectAPI> GetLocation(Guid nvID)
        {
            var clt = await db.CurrentLocationTrackings.Where(n => n.NVID.Equals(nvID)).FirstOrDefaultAsync();

            ObjectAPI obj = new ObjectAPI();

            if (clt == null)
            {
                obj.StatusCode = "404";
                obj.Success = false;
                obj.Message = "Lấy vị trí thất bại";
                obj.Data = new object();
            }
            else
            {
                obj.StatusCode = "200";
                obj.Success = true;
                obj.Message = "Lấy vị trí thành công!";
                obj.Data = clt;
            }

            return obj;
        }

        public async Task<bool> UpdateLocation(CurrentLocationTracking clt)
        {
            if (clt == null)
                return false;
            var cur = await db.CurrentLocationTrackings.Where(n => n.NVID.Equals(clt.NVID)).FirstOrDefaultAsync();

            if (cur != null)
            {
                cur.KinhDo = clt.KinhDo;
                cur.ViDo = clt.ViDo;
                cur.NgaySua = DateTime.Now;
                cur.NguoiSua = cur.NVID.ToString();
                db.Entry(cur).State = EntityState.Modified;
            }
            else
            {
                cur.NguoiTao = cur.NVID.ToString();
                cur.NgayTao = DateTime.Now;
                db.CurrentLocationTrackings.Add(clt);
            }


            await db.SaveChangesAsync();


            return true;
        }

    }
}