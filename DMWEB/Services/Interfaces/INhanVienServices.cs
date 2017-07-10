using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using DMWEB.Models;

namespace DMWEB.Services.Interfaces
{
    public interface INhanVienServices
    {
        Task<NhanVien> GetInfo(Guid id);

    }
}