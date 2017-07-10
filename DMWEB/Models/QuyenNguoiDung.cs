namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuyenNguoiDung")]
    public partial class QuyenNguoiDung
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string MaQuyen { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UserID { get; set; }

        public string GhiChu { get; set; }
    }
}
