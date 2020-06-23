namespace ElectronicWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }
        [DisplayName("Tên Nhân Viên")]
        [StringLength(50)]
        public string TenNV { get; set; }

        [StringLength(5)]
        public string GT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NS { get; set; }

        [StringLength(13)]
        public string SĐT { get; set; }

        [StringLength(300)]
        public string photo { get; set; }

        public double? Luong { get; set; }

        public virtual ADMIN ADMIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
