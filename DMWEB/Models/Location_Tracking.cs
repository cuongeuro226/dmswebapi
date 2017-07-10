namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Location_Tracking
    {
        public int ID { get; set; }

        public Guid? NVID { get; set; }

        public DateTime? DateTracking { get; set; }

        [StringLength(8)]
        public string GioBD { get; set; }

        [StringLength(8)]
        public string GioKT { get; set; }

        public string NguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public string NguoiSua { get; set; }

        public DateTime? NgaySua { get; set; }

        public string GhiChu { get; set; }
    }
}
