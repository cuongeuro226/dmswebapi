namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinhThanh")]
    public partial class TinhThanh
    {
        public Guid ID { get; set; }

        [StringLength(16)]
        public string MaTT { get; set; }

        [StringLength(128)]
        public string TenTT { get; set; }

        [StringLength(128)]
        public string TenTT2 { get; set; }

        public string NguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public string NguoiSua { get; set; }

        public DateTime? NgaySua { get; set; }

        public string GhiChu { get; set; }
    }
}
