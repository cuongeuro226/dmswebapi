using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using DMWEB.Models;
using DMWEB.Services.Implements;
using DMWEB.Services.Interfaces;

namespace DMWEB.Controllers
{
    [System.Web.Http.AllowAnonymous]
    public class AccountController : ApiController
    {
        TokenServices tokenService = new TokenServices();
        UserServices userServices = new UserServices();
        /// <summary>
        /// Gen tokens
        /// </summary>
        /// <param name="nvID"></param>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        public object GenToken(string nvID)
        {
            var token = tokenService.GenToken(nvID);
            if (token != null)
            {
                return new {Message = "Thành công", Success = Boolean.TrueString };

            }
            return new {Message = "Thất bại", Success = Boolean.FalseString};
        }

        /// <summary>
        /// Xác nhận phiên đăng nhập
        /// </summary>
        /// <param name="tokenID"></param>
        /// <returns></returns>
        public object ValidateToken(string tokenID)
        {
            if (tokenService.ValidateToken(tokenID))
            {
                return new {Message = "Thành công", Success = Boolean.TrueString};
            }
            else
            {
                return new { Message = "Thất bại", Success = Boolean.FalseString };
            }
        }

        /// <summary>
        /// Xóa token
        /// </summary>
        /// <param name="tokenID"></param>
        /// <returns></returns>
        public object KillToken(string tokenID)
        {
            if (tokenService.Kill(tokenID))
            {
                return new { Message = "Đã xóa", Success = Boolean.TrueString };
            }
            else
            {
                return new { Message = "Xóa thất bại", Success = Boolean.FalseString };
            }
        }

        /// <summary>
        /// Xóa token nhân viên
        /// </summary>
        /// <param name="nvID"></param>
        /// <returns></returns>
        public object DeleteByUser(string nvID)
        {
            if (tokenService.DeleteByUserId(Guid.Parse(nvID)))
            {
                return new { Message = "Đã xóa", Success = Boolean.TrueString };
            }
            else
            {
                return new { Message = "Xóa thất bại", Success = Boolean.FalseString };
            }
        }

        /// <summary>
        /// Đăng nhập 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        public ObjectAPI Login(string userName, string password)
        {
            var id = userServices.Authenticate(userName, password);

            ObjectAPI obj = new ObjectAPI();

            if (id == Guid.Empty)
            {
                obj.Message = "Tài khoản hoặc mật khẩu không đúng";
                obj.Success = false;
                obj.Data = new object();
                obj.StatusCode = "500";
            }
            else
            {
                obj.Message = "Đăng nhập thành công";
                obj.Success = true;
                obj.Data = tokenService.GenToken(id.ToString());
                obj.StatusCode = "200";
            }
            return obj;
        }
    }
}
