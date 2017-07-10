namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        public Guid ID { get; set; }

        [StringLength(16)]
        public string MaSP { get; set; }

        [StringLength(128)]
        public string TenSP { get; set; }

        [StringLength(128)]
        public string TenSP2 { get; set; }

        [StringLength(16)]
        public string DVT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DonGia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VAT { get; set; }

        [StringLength(64)]
        public string NhaSX { get; set; }

        [StringLength(64)]
        public string NuocSX { get; set; }

        [StringLength(1)]
        public string TrangThai { get; set; }

        public DateTime? NgayTao { get; set; }

        public string NguoiTao { get; set; }

        public DateTime? NgaySua { get; set; }

        public string NguoiSua { get; set; }

        public string GhiChu { get; set; }
    }
}
