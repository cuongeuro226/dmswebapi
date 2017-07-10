namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViengTham")]
    public partial class ViengTham
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(16)]
        public string MaVT { get; set; }

        public Guid? NVID { get; set; }

        public Guid? KHID { get; set; }

        public string NguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public string NguoiSua { get; set; }

        public DateTime? NgaySua { get; set; }

        public string GhiChu { get; set; }
    }
}
