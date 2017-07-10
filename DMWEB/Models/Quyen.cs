namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quyen")]
    public partial class Quyen
    {
        public int ID { get; set; }

        [StringLength(32)]
        public string MaQuyen { get; set; }

        [StringLength(128)]
        public string TenQuyen { get; set; }

        public string GhiChu { get; set; }
    }
}
