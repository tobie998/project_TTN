namespace ElectronicWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("Mã Khách Hàng")]
        [Required(ErrorMessage = "Bạn chưa nhập mã khách hàng")]
        public int MaKH { get; set; }
        
        [StringLength(50)]
        [DisplayName("Tên Khách Hàng")]
        [Required(ErrorMessage ="Bạn chưa nhập tên")]
        public string TenKH { get; set; }

        [StringLength(5)]
        [DisplayName("Giới Tính")]
        [Required(ErrorMessage = "Bạn chưa nhập Số Điện Thoại")]
        public string GT { get; set; }

        [StringLength(10, ErrorMessage ="Số điện thoại phải gồm 10 số")]
        [DisplayName("Số Điện Thoại")]
        [Required(ErrorMessage = "Bạn chưa nhập Số Điện Thoại")]
        [Range(0,Int32.MaxValue,ErrorMessage ="Bạn phải nhập số")]
        public string SDT { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày Sinh")]
        [Required(ErrorMessage = "Bạn chưa nhập ngày sinh")]
        public DateTime? NgaySinh { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
