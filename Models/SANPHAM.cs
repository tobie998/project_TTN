namespace ElectronicWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;
  

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        DienTuModel db = new DienTuModel();
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIET_HOADON = new HashSet<CHITIET_HOADON>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("Mã Sản Phẩm")]
        [Required(ErrorMessage = "Bạn chưa nhập mã sản phẩm")]
        public int MaSP { get; set; }
        
        [StringLength(50)]
        [DisplayName("Tên Sản Phẩm")]
        [Required(ErrorMessage = "Bạn chưa nhập tên sản phẩm")]
        public string TenSP { get; set; }
        [DisplayName("Giá")]
        [Required(ErrorMessage = "Bạn chưa nhập giá sản phẩm")]
        public double? Gia { get; set; }
        [DisplayName("Năm Sản Xuất")]
        [Required(ErrorMessage = "Bạn chưa nhập năm sản xuất")]
        public DateTime NgaySX { get; set; }
        [DisplayName("Tình Trạng")]
        [StringLength(30)]
        public string TinhTrang { get; set; }
        [DisplayName("Ảnh")]
        [StringLength(50)]
        public string Photo { get; set; }
        
        [DisplayName("Loại Hàng")]
        public int? MaLH { get; set; }
        [DisplayName("Thương Hiệu")]
        public int? MaHSX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_HOADON> CHITIET_HOADON { get; set; }

        public virtual GIOHANG GIOHANG { get; set; }

        public virtual HANG_SX HANG_SX { get; set; }

        public virtual LOAIHANG LOAIHANG { get; set; }
        public SANPHAM ViewDetail(long id)
        {
            return db.SANPHAMs.Find(id);
        }

    }
}
