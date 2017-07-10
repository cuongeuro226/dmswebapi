namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomNguoiDung")]
    public partial class NhomNguoiDung
    {
        public int ID { get; set; }

        [StringLength(16)]
        public string MaNhomNguoiDung { get; set; }

        [StringLength(128)]
        public string TenNhomNguoiDung { get; set; }

        public string GhiChu { get; set; }
    }
}
