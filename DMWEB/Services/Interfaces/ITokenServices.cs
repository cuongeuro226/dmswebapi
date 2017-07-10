using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMWEB.Models;

namespace DMWEB.Services.Interfaces
{
    interface ITokenServices
    {
        Token GenToken(string nVID);
        bool ValidateToken(string tokenId);

        bool Kill(string tokenId);

        bool DeleteByUserId(Guid nVID);
    }
}
