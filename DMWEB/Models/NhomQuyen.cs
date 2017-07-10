namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomQuyen")]
    public partial class NhomQuyen
    {
        public int ID { get; set; }

        [StringLength(32)]
        public string MaNhom { get; set; }

        [StringLength(128)]
        public string TenNhom { get; set; }

        public string GhiChu { get; set; }
    }
}
