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
    public class NhanVienServices : INhanVienServices
    {
        DMSContext db = new DMSContext();
        public async Task<NhanVien> GetInfo(Guid id)
        {
            try
            {
                var nv = await db.NhanViens.Where(n => n.ID.Equals(id)).FirstOrDefaultAsync();
                return nv;
            }
            catch (Exception ex)
            {
                return new NhanVien();
            }
        }
    }
}