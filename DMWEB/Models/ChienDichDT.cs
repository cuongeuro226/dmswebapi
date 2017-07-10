namespace DMWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChienDichDT")]
    public partial class ChienDichDT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string Ben { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid NVID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Address { get; set; }

        [StringLength(64)]
        public string SoBD { get; set; }

        [StringLength(64)]
        public string SoKT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? K1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? V1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? K2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? V2 { get; set; }

        public DateTime? NgayTao { get; set; }

        public string NguoiTao { get; set; }

        public DateTime? NgaySua { get; set; }

        public string NguoiSua { get; set; }

        public string GhiChu { get; set; }
    }
}
