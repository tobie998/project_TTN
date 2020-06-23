namespace ElectronicWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMINS")]
    public partial class ADMIN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        [StringLength(50)]
        public string TenLOGIN { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
