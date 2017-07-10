namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        public Guid ID { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(128)]
        public string TenNV { get; set; }

        [StringLength(128)]
        public string TenNV2 { get; set; }

        [StringLength(10)]
        public string ChucVu { get; set; }

        public Guid? PhongBan { get; set; }

        public DateTime? NgayTao { get; set; }

        public string NguoiTao { get; set; }

        public DateTime? NgaySua { get; set; }

        public string NguoiSua { get; set; }

        public string GhiChu { get; set; }
    }
}
