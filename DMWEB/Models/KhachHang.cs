namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        public Guid ID { get; set; }

        [StringLength(16)]
        public string MaKH { get; set; }

        [StringLength(128)]
        public string TenKH { get; set; }

        [StringLength(128)]
        public string TenKH2 { get; set; }

        [StringLength(32)]
        public string Ho { get; set; }

        [StringLength(32)]
        public string TenDem { get; set; }

        [StringLength(32)]
        public string Ten { get; set; }

        public Guid? TTID { get; set; }

        public Guid? QHID { get; set; }

        [StringLength(128)]
        public string PhuongXa { get; set; }

        [StringLength(128)]
        public string TenDuong { get; set; }

        [StringLength(64)]
        public string SoNha { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(64)]
        public string Chucvu { get; set; }

        [StringLength(1)]
        public string HonNhan { get; set; }

        [StringLength(32)]
        public string DienThoai { get; set; }

        [StringLength(32)]
        public string DienThoai2 { get; set; }

        [StringLength(64)]
        public string Email { get; set; }

        public DateTime? NgayCuoi { get; set; }

        [StringLength(64)]
        public string MaSoThue { get; set; }

        [StringLength(1)]
        public string TrangThai { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DienTich { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SLNV { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SLKH { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DoanhSo { get; set; }

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
