using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMWEB.Services.Interfaces
{
    interface IUserServices
    {
        Guid Authenticate(string username, string password);

    }
}
