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

    
    public class NhanVienController : ApiController
    {
        NhanVienServices nvServices = new NhanVienServices();


        public async Task<ObjectAPI> GetInfo(string id)
        {
            ObjectAPI obj = new ObjectAPI();

            var nv = await nvServices.GetInfo(Guid.Parse(id));

            if (!string.IsNullOrEmpty(nv.ID.ToString()))
            {
                obj.StatusCode = "200";
                obj.Message = "Thành công";
                obj.Success = true;
                obj.Data = nv;
            }
            else
            {
                obj.StatusCode = "404";
                obj.Message = "Không tìm thấy nhân viên này";
                obj.Success = false;
                obj.Data = new Object();
            }

            return obj;
        }


    }
}
