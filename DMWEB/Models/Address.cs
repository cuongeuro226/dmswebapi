namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        public int ID { get; set; }

        [Column("Address")]
        [StringLength(128)]
        public string Address1 { get; set; }

        public int? ParentID { get; set; }

        public int? TT { get; set; }

        [StringLength(1)]
        public string Type { get; set; }
    }
}
