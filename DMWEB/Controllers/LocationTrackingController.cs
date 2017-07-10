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
    public class LocationTrackingController : ApiController
    {
        LocationTrackingServices localServices = new LocationTrackingServices();

        [HttpPost]
        public async Task<ObjectAPI> UpdateLocation([FromBody]Location_Tracking location)
        {

            ObjectAPI obj = new ObjectAPI();

            var rel = await localServices.UpdateLocation(location);

            obj.Data = rel;
            if (rel)
            {
                obj.Message = "Thành công!";
                obj.Success = true;
                obj.StatusCode = "200";
            }
            else
            {
                obj.Message = "Thất bại";
                obj.StatusCode = "404";
                obj.Success = false;
            }


            return obj;
        }

        public async Task<ObjectAPI> GetListByID(string id)
        {
            ObjectAPI obj = new ObjectAPI();

            var rel = await localServices.GetList(Guid.Parse(id));

            if (rel.Count() > 0)
            {
                obj.Message = "Lấy thành công danh sách vị trí";
                obj.StatusCode = "200";
                obj.Success = true;
            }
            else
            {
                obj.Message = "Lấy danh sách vị trí thất bại";
                obj.StatusCode = "404";
                obj.Success = false;
            }
            obj.Data = rel;

            return obj;
        }

        public async Task<ObjectAPI> GetListByDate(string date)
        {
            ObjectAPI obj = new ObjectAPI();


            if (DateTime.TryParse(date, out DateTime newDate))
            {
                var rel = await localServices.GetList(newDate);

                if (rel.Count() > 0)
                {
                    obj.Message = "Lấy thành công danh sách vị trí";
                    obj.StatusCode = "200";
                    obj.Success = true;
                }
                else
                {
                    obj.Message = "Lấy danh sách vị trí thất bại";
                    obj.StatusCode = "404";
                    obj.Success = false;
                }
                obj.Data = rel;
            }

            return obj;
        }
    }
}
