namespace ElectronicWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIOHANG")]
    public partial class GIOHANG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSP { get; set; }

        public int? SoLuong { get; set; }

        public double? Gia { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
