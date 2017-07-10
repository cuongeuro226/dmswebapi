using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DMWEB.Models;
using DMWEB.Services.Interfaces;

namespace DMWEB.Services.Implements
{
    public class TokenServices : ITokenServices
    {
        DMSContext db = new DMSContext();
        
        public Token GenToken(string nVID)
        {
            Token token = new Token();
            token.NVID = Guid.Parse(nVID);
            token.Tokens = Guid.NewGuid().ToString();
            token.StartDate = DateTime.Now;
            token.ExpireDate = DateTime.Now.AddSeconds(
                Convert.ToDouble(ConfigurationManager.AppSettings["AuthTokenExpiry"]));
            db.Tokens.Add(token);

            db.SaveChanges();

            return token;
        }

        public bool ValidateToken(string tokenId)
        {
            var token = db.Tokens.Where(n => n.Tokens.Equals(tokenId) && n.ExpireDate > DateTime.Now).FirstOrDefault();
            if (token != null && !(DateTime.Now > token.ExpireDate))
            {
                token.ExpireDate = token.ExpireDate.Value.AddSeconds(
                    Convert.ToDouble(ConfigurationManager.AppSettings["AuthTokenExpiry"]));
                
                db.Entry(token).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            return false;
        }

        public bool Kill(string tokenId)
        {
            var token = db.Tokens.Where(n=>n.Tokens.Equals(tokenId)).FirstOrDefault();

            if (token != null)
            {
                db.Tokens.Remove(token);
                db.SaveChanges();
                return true;

            }
            return false;
        }

        public bool DeleteByUserId(Guid nVID)
        {
            var tokens = db.Tokens.Where(n => n.NVID.Equals(nVID));

            if (tokens != null)
            {
                db.Tokens.RemoveRange(tokens);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}