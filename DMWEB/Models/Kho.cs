namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kho")]
    public partial class Kho
    {
        public Guid ID { get; set; }

        [StringLength(16)]
        public string MaKho { get; set; }

        [StringLength(128)]
        public string TenKho { get; set; }

        [StringLength(128)]
        public string TenKho2 { get; set; }

        [StringLength(1)]
        public string TrangThai { get; set; }

        public string NguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public string NguoiSua { get; set; }

        public DateTime? NgaySua { get; set; }

        public string GhiChu { get; set; }
    }
}
