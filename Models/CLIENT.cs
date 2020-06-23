namespace ElectronicWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENTS")]
    public partial class CLIENT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKH { get; set; }

        [StringLength(50)]
        public string TenLOGIN { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
