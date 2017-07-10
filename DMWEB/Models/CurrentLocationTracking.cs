using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DMWEB.Models
{
    [Table("CurrentLocationTracking")]
    public partial class CurrentLocationTracking
    {
        [Key]
        public Guid NVID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? KinhDo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ViDo { get; set; }

        public string NguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public string NguoiSua { get; set; }

        public DateTime? NgaySua { get; set; }

        public string GhiChu { get; set; }


    }
}