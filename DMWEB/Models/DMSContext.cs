namespace DMWEB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DMSContext : DbContext
    {
        public DMSContext()
            : base("name=DMSContext")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<ChienDich> ChienDiches { get; set; }
        public virtual DbSet<ChienDichDT> ChienDichDTs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Kho> Khoes { get; set; }
        public virtual DbSet<Location_Tracking> Location_Tracking { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhomNguoiDung> NhomNguoiDungs { get; set; }
        public virtual DbSet<NhomQuyen> NhomQuyens { get; set; }
        public virtual DbSet<NhomQuyenNguoiDung> NhomQuyenNguoiDungs { get; set; }
        public virtual DbSet<QuanHuyen> QuanHuyens { get; set; }
        public virtual DbSet<Quyen> Quyens { get; set; }
        public virtual DbSet<QuyenNguoiDung> QuyenNguoiDungs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TinhThanh> TinhThanhs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ViengTham> ViengThams { get; set; }

        public virtual DbSet<CurrentLocationTracking> CurrentLocationTrackings { get; set; }

        public virtual DbSet<Token> Tokens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Address>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<ChienDich>()
                .Property(e => e.MaCD)
                .IsUnicode(false);

            modelBuilder.Entity<ChienDichDT>()
                .Property(e => e.Ben)
                .IsUnicode(false);

            modelBuilder.Entity<ChienDichDT>()
                .Property(e => e.K1)
                .HasPrecision(18, 10);

            modelBuilder.Entity<ChienDichDT>()
                .Property(e => e.V1)
                .HasPrecision(18, 10);

            modelBuilder.Entity<ChienDichDT>()
                .Property(e => e.K2)
                .HasPrecision(18, 10);

            modelBuilder.Entity<ChienDichDT>()
                .Property(e => e.V2)
                .HasPrecision(18, 10);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaDH)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.LoaiDH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.HonNhan)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DienThoai2)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaSoThue)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TrangThai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SLNV)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SLKH)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.KinhDo)
                .HasPrecision(18, 10);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.ViDo)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Kho>()
                .Property(e => e.MaKho)
                .IsUnicode(false);

            modelBuilder.Entity<Kho>()
                .Property(e => e.TrangThai)
                .IsUnicode(false);

            modelBuilder.Entity<Location_Tracking>()
                .Property(e => e.GioBD)
                .IsUnicode(false);

            modelBuilder.Entity<Location_Tracking>()
                .Property(e => e.GioKT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NhomNguoiDung>()
                .Property(e => e.MaNhomNguoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<NhomQuyen>()
                .Property(e => e.MaNhom)
                .IsUnicode(false);

            modelBuilder.Entity<QuanHuyen>()
                .Property(e => e.MaQH)
                .IsUnicode(false);

            modelBuilder.Entity<Quyen>()
                .Property(e => e.MaQuyen)
                .IsUnicode(false);

            modelBuilder.Entity<QuyenNguoiDung>()
                .Property(e => e.MaQuyen)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.VAT)
                .HasPrecision(5, 2);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.TrangThai)
                .IsUnicode(false);

            modelBuilder.Entity<TinhThanh>()
                .Property(e => e.MaTT)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.MaUser)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Tokens)
                .IsUnicode(false);

            modelBuilder.Entity<ViengTham>()
                .Property(e => e.MaVT)
                .IsUnicode(false);
        }
    }
}
