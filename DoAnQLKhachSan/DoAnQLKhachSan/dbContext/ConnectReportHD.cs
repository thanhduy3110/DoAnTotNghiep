using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAnQLKhachSan.dbContext
{
    public partial class ConnectReportHD : DbContext
    {
        public ConnectReportHD()
            : base("name=ConnectReportHD")
        {
        }

        public virtual DbSet<CTHD> CTHDs { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiDV> LoaiDVs { get; set; }
        public virtual DbSet<LoaiNV> LoaiNVs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuDatPhong> PhieuDatPhongs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<PhongDaDat> PhongDaDats { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.CTHDs)
                .WithOptional(e => e.DichVu)
                .HasForeignKey(e => e.ID_DV);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.CTHDs)
                .WithOptional(e => e.HoaDon)
                .HasForeignKey(e => e.ID_HD);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithOptional(e => e.KhachHang)
                .HasForeignKey(e => e.ID_KH);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuDatPhongs)
                .WithOptional(e => e.KhachHang)
                .HasForeignKey(e => e.ID_KH);

            modelBuilder.Entity<LoaiDV>()
                .HasMany(e => e.DichVus)
                .WithOptional(e => e.LoaiDV)
                .HasForeignKey(e => e.ID_LoaiDV);

            modelBuilder.Entity<LoaiNV>()
                .HasMany(e => e.NhanViens)
                .WithOptional(e => e.LoaiNV)
                .HasForeignKey(e => e.ID_LoaiNV);

            modelBuilder.Entity<LoaiPhong>()
                .HasMany(e => e.Phongs)
                .WithOptional(e => e.LoaiPhong)
                .HasForeignKey(e => e.ID_LoaiPhong);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.ID_NV);

            modelBuilder.Entity<PhieuDatPhong>()
                .HasMany(e => e.PhongDaDats)
                .WithOptional(e => e.PhieuDatPhong)
                .HasForeignKey(e => e.ID_PhieuDP);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.HoaDons)
                .WithOptional(e => e.Phong)
                .HasForeignKey(e => e.ID_Phong);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.PhongDaDats)
                .WithOptional(e => e.Phong)
                .HasForeignKey(e => e.ID_Phong);
        }
    }
}
