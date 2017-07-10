using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using DMWEB.Models;
using DMWEB.Services.Implements;

namespace DMWEB.Controllers
{
    public class ChienDichController : ApiController
    {
        ChienDichServices chienDichServices = new ChienDichServices();

        public async Task<ObjectAPI> GetChienDichByID(string id)
        {
            ObjectAPI obj = new ObjectAPI();

            var rel = await chienDichServices.GetListChienDich(Guid.Parse(id));

            if (rel != null && rel.Count() > 0)
            {
                obj.Message = "Lấy danh sách thông tin chiến dịch thành công!";
                obj.StatusCode = "200";
                obj.Success = true;
                obj.Data = rel;
            }
            else
            {
                obj.Message = "Sai thông tin truy vấn hoặc dữ liệu không tồn tại";
                obj.StatusCode = "404";
                obj.Success = false;
                obj.Data = new object();
            }
            return obj;
        }

        public async Task<ObjectAPI> GetChienDichByDate(string start, string end)
        {

            ObjectAPI obj = new ObjectAPI();

            if (DateTime.TryParse(start, out DateTime newStart) && DateTime.TryParse(end, out DateTime newEnd))
            {



                var rel = await chienDichServices.GetListChienDich(newStart, newEnd);

                if (rel != null && rel.Count() > 0)
                {
                    obj.Message = "Lấy danh sách thông tin chiến dịch thành công!";
                    obj.StatusCode = "200";
                    obj.Success = true;
                    obj.Data = rel;
                }
                else
                {
                    obj.Message = "Sai thông tin truy vấn hoặc dữ liệu không tồn tại";
                    obj.StatusCode = "404";
                    obj.Success = false;
                    obj.Data = new object();
                }
            }
            return obj;
        }

    }
}
