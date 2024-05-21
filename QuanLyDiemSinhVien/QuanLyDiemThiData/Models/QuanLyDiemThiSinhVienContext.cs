using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QuanLyDiemThi.Data.Models
{
    public partial class DiemThiContext : DbContext
    {
        public DiemThiContext()
        {
        }

        public DiemThiContext(DbContextOptions<DiemThiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChucDanh> ChucDanhs { get; set; }
        public virtual DbSet<GiangVien> GiangViens { get; set; }
        public virtual DbSet<HocKy> HocKies { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<KhoaDaoTao> KhoaDaoTaos { get; set; }
        public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<LopHocPhan> LopHocPhans { get; set; }
        public virtual DbSet<LopHpSinhVien> LopHpSinhViens { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<NienKhoa> NienKhoas { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<TinChi> TinChis { get; set; }
        public virtual DbSet<XepLoai> XepLoais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-8IQ24J3K\\MSSQLSERVER03;Initial Catalog=QuanLyDiemThiSinhVien;Integrated Security=True;Connect Timeout=30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChucDanh>(entity =>
            {
                entity.ToTable("ChucDanh");

                entity.Property(e => e.ChucDanhId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChucDanhID");

                entity.Property(e => e.MaChucDanh).HasMaxLength(100);

                entity.Property(e => e.TenChucDanh).HasMaxLength(200);
            });

            modelBuilder.Entity<GiangVien>(entity =>
            {
                entity.ToTable("GiangVien");

                entity.Property(e => e.GiangVienId)
                    .ValueGeneratedNever()
                    .HasColumnName("GiangVienID");

                entity.Property(e => e.ChucDanhId).HasColumnName("ChucDanhID");

                entity.Property(e => e.DienThoai).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.HoTenGv)
                    .HasMaxLength(200)
                    .HasColumnName("HoTenGV");

                entity.Property(e => e.KhoaId).HasColumnName("KhoaID");

                entity.Property(e => e.MaGv)
                    .HasMaxLength(100)
                    .HasColumnName("MaGV");

                entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<HocKy>(entity =>
            {
                entity.ToTable("HocKy");

                entity.Property(e => e.HocKyId)
                    .ValueGeneratedNever()
                    .HasColumnName("HocKyID");

                entity.Property(e => e.MaHocKy).HasMaxLength(100);

                entity.Property(e => e.NamHocId).HasColumnName("NamHocID");

                entity.Property(e => e.TenHocKy).HasMaxLength(200);
            });

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.ToTable("Khoa");

                entity.Property(e => e.KhoaId)
                    .ValueGeneratedNever()
                    .HasColumnName("KhoaID");

                entity.Property(e => e.Dt)
                    .HasMaxLength(20)
                    .HasColumnName("DT");

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.MaKhoa).HasMaxLength(100);

                entity.Property(e => e.TenKhoa).HasMaxLength(500);
            });

            modelBuilder.Entity<KhoaDaoTao>(entity =>
            {
                entity.ToTable("KhoaDaoTao");

                entity.Property(e => e.KhoaDaoTaoId)
                    .ValueGeneratedNever()
                    .HasColumnName("KhoaDaoTaoID");

                entity.Property(e => e.NamDaoTao).HasColumnType("date");

                entity.Property(e => e.NamTcdt).HasColumnName("NamTCDT");

                entity.Property(e => e.NamTddt).HasColumnName("NamTDDT");

                entity.Property(e => e.NganhId).HasColumnName("NganhID");

                entity.Property(e => e.TenKhoaDt)
                    .HasMaxLength(200)
                    .HasColumnName("TenKhoaDT");
            });

            modelBuilder.Entity<LoaiTaiKhoan>(entity =>
            {
                entity.ToTable("LoaiTaiKhoan");

                entity.Property(e => e.LoaiTaiKhoanId)
                    .ValueGeneratedNever()
                    .HasColumnName("LoaiTaiKhoanID");

                entity.Property(e => e.TenLoaiTaiKhoan).HasMaxLength(500);
            });

            modelBuilder.Entity<Lop>(entity =>
            {
                entity.Property(e => e.LopId)
                    .ValueGeneratedNever()
                    .HasColumnName("LopID");

                entity.Property(e => e.KhoaId).HasColumnName("KhoaID");

                entity.Property(e => e.MaLop).HasMaxLength(100);

                entity.Property(e => e.TenLop).HasMaxLength(500);
            });

            modelBuilder.Entity<LopHocPhan>(entity =>
            {
                entity.HasKey(e => e.LopHpid);

                entity.ToTable("LopHocPhan");

                entity.Property(e => e.LopHpid)
                    .ValueGeneratedNever()
                    .HasColumnName("LopHPID");

                entity.Property(e => e.GiangVienId).HasColumnName("GiangVienID");

                entity.Property(e => e.HocKyId).HasColumnName("HocKyID");

                entity.Property(e => e.MaLopHp)
                    .HasMaxLength(100)
                    .HasColumnName("MaLopHP");

                entity.Property(e => e.MonHocId).HasColumnName("MonHocID");

                entity.Property(e => e.SoluongSv).HasColumnName("SoluongSV");

                entity.Property(e => e.TenLopHp)
                    .HasMaxLength(500)
                    .HasColumnName("TenLopHP");
            });

            modelBuilder.Entity<LopHpSinhVien>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LopHP_SinhVien");

                entity.Property(e => e.LopHpid).HasColumnName("LopHPID");

                entity.Property(e => e.SinhVienId).HasColumnName("SinhVienID");
            });

            modelBuilder.Entity<MonHoc>(entity =>
            {
                entity.ToTable("MonHoc");

                entity.Property(e => e.MonHocId)
                    .ValueGeneratedNever()
                    .HasColumnName("MonHocID");

                entity.Property(e => e.KhoaId).HasColumnName("KhoaID");

                entity.Property(e => e.NganhId).HasColumnName("NganhID");

                entity.Property(e => e.Tclt).HasColumnName("TCLT");

                entity.Property(e => e.Tcth).HasColumnName("TCTH");

                entity.Property(e => e.TenMonHoc).HasMaxLength(200);

                entity.Property(e => e.TheLoaiId).HasColumnName("TheLoaiID");
            });

            modelBuilder.Entity<NienKhoa>(entity =>
            {
                entity.ToTable("NienKhoa");

                entity.Property(e => e.NienKhoaId)
                    .ValueGeneratedNever()
                    .HasColumnName("NienKhoaID");

                entity.Property(e => e.MaNienKhoa).HasMaxLength(100);

                entity.Property(e => e.TenNienKhoa).HasMaxLength(200);
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.ToTable("SinhVien");

                entity.Property(e => e.SinhVienId)
                    .ValueGeneratedNever()
                    .HasColumnName("SinhVienID");

                entity.Property(e => e.DanToc).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.HoTenSv)
                    .HasMaxLength(200)
                    .HasColumnName("HoTenSV");

                entity.Property(e => e.LopId).HasColumnName("LopID");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(100)
                    .HasColumnName("MaSV");

                entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");

                entity.Property(e => e.NoiSinh).HasMaxLength(300);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.ToTable("TaiKhoan");

                entity.Property(e => e.TaiKhoanId)
                    .ValueGeneratedNever()
                    .HasColumnName("TaiKhoanID");

                entity.Property(e => e.KhachHangId).HasColumnName("KhachHangID");

                entity.Property(e => e.LoaiTaiKhoanId).HasColumnName("LoaiTaiKhoanID");

                entity.Property(e => e.MatKhau).HasMaxLength(100);

                entity.Property(e => e.TenTaiKhoan).HasMaxLength(500);
            });

            modelBuilder.Entity<TheLoai>(entity =>
            {
                entity.ToTable("TheLoai");

                entity.Property(e => e.TheLoaiId)
                    .ValueGeneratedNever()
                    .HasColumnName("TheLoaiID");

                entity.Property(e => e.MaTheLoai).HasMaxLength(100);

                entity.Property(e => e.TenTheLoai).HasMaxLength(500);
            });

            modelBuilder.Entity<TinChi>(entity =>
            {
                entity.ToTable("TinChi");

                entity.Property(e => e.TinChiId)
                    .ValueGeneratedNever()
                    .HasColumnName("TinChiID");

                entity.Property(e => e.MaTinhChi).HasMaxLength(100);
            });

            modelBuilder.Entity<XepLoai>(entity =>
            {
                entity.ToTable("XepLoai");

                entity.Property(e => e.XepLoaiId)
                    .ValueGeneratedNever()
                    .HasColumnName("XepLoaiID");

                entity.Property(e => e.DiemBd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DiemBD");

                entity.Property(e => e.DiemKetThuc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaXepLoai).HasMaxLength(100);

                entity.Property(e => e.TenXepLoai).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
