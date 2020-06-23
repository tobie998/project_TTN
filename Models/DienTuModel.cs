namespace ElectronicWEB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DienTuModel : DbContext
    {
        public DienTuModel()
            : base("name=DienTuModel")
        {
        }

        public virtual DbSet<ADMIN> ADMINS { get; set; }
        public virtual DbSet<CHITIET_HOADON> CHITIET_HOADON { get; set; }
        public virtual DbSet<CLIENT> CLIENTS { get; set; }
        public virtual DbSet<GIOHANG> GIOHANGs { get; set; }
        public virtual DbSet<HANG_SX> HANG_SX { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIHANG> LOAIHANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIET_HOADON)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasOptional(e => e.CLIENT)
                .WithRequired(e => e.KHACHHANG);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SĐT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasOptional(e => e.ADMIN)
                .WithRequired(e => e.NHANVIEN);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIET_HOADON)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasOptional(e => e.GIOHANG)
                .WithRequired(e => e.SANPHAM);
        }
    }
}
