using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMWEB.Models
{
    public class ObjectAPI
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public Object Data { get; set; }
        public string StatusCode { get; set; }

        public ObjectAPI()
        {
            
        }
    }
}