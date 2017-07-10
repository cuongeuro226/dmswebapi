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
    public class UserServices : IUserServices
    {
        DMSContext db = new DMSContext();
        public Guid Authenticate(string username, string password)
        {
            var user = db.Users.Where(n => n.MaUser.Equals(username) && n.Password.Equals(password)).FirstOrDefault();

            if (user != null)
            {
                return user.ID;
            }
            return Guid.Empty;
        }
    }
}