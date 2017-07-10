namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public Guid ID { get; set; }

        [StringLength(64)]
        public string MaUser { get; set; }

        [StringLength(128)]
        public string UserName { get; set; }

        [StringLength(128)]
        public string Password { get; set; }

        public bool? IsAdmin { get; set; }

        public string NguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public string NguoiSua { get; set; }

        public DateTime? NgaySua { get; set; }

        public string GhiChu { get; set; }

        [StringLength(256)]
        public string Tokens { get; set; }

        public Guid? NVID { get; set; }
    }
}
