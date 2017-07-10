namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChienDich")]
    public partial class ChienDich
    {
        public int ID { get; set; }

        [StringLength(32)]
        public string MaCD { get; set; }

        [StringLength(128)]
        public string TenCD { get; set; }

        public DateTime? NgayBD { get; set; }

        public DateTime? NgayKT { get; set; }

        public DateTime? NgayTao { get; set; }

        public string NguoiTao { get; set; }

        public DateTime? NgaySua { get; set; }

        public string NguoiSua { get; set; }

        public string GhiChu { get; set; }
    }
}
