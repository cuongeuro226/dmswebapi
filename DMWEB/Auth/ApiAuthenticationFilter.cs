using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using DMWEB.Models;
using DMWEB.Services.Implements;

namespace DMWEB.Auth
{
    public class ApiAuthenticationFilter : DmsAuthenticationFilter
    {
        public ApiAuthenticationFilter()
        {
            
        }

        public ApiAuthenticationFilter(bool isActive) : base(isActive)
        {
            
        }

        protected override bool OnAuthorizeUser(string user, string password, HttpActionContext filterContext)
        {
            var userService = new UserServices();

            var id = userService.Authenticate(user, password);

            if (id == Guid.Empty)
            {
                var basicAuthenticationIdentity = Thread.CurrentPrincipal.Identity as BasicAuthenticationIdentity;
                if (basicAuthenticationIdentity != null)
                {
                    basicAuthenticationIdentity.UserId = id;
                }
                return true;
            }

            return false;
        }
    }
}