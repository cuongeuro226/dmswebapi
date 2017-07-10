using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DMWEB.Models
{
    [Table("Token")]
    public class Token
    {
        [Key]
        public int ID { get; set; }
        public Guid? NVID { get; set; }
        public string Tokens { get; set; }
        public DateTime? StartDate { get; set; }

        public DateTime? ExpireDate{ get; set; }

    }
}