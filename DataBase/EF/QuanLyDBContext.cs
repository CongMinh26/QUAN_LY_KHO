using System;
using System.Collections.Generic;
using System.Text;
using DataBase.Configuration;
using DataBase.Entities;
/*using DataBase.Configuration;
using DataBase.Entities;*/
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataBase.EF
{
   public class QuanLyDBContext : IdentityDbContext<NhanVien, Role, Guid>
    {
        public QuanLyDBContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new Role_Configuration());
            modelBuilder.ApplyConfiguration(new CTPN_Configuration());
            modelBuilder.ApplyConfiguration(new CTPX_Configuration());
            modelBuilder.ApplyConfiguration(new KhachHang_Configuration());
            modelBuilder.ApplyConfiguration(new NhanVien_Configuration());
            modelBuilder.ApplyConfiguration(new NhaCungCap_Configuration());
            modelBuilder.ApplyConfiguration(new PhieuNhap_Configuration());
            modelBuilder.ApplyConfiguration(new PhieuXuat_Configuration());
            modelBuilder.ApplyConfiguration(new VatTu_Configuration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("NhanVienClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("NhanVienRole").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("NhanVienLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("NhanVienTokens").HasKey(x => x.UserId);

        }
        public DbSet<CTPN> CTPNs { get; set; }
        public DbSet<CTPX> CTPXs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public DbSet<PhieuXuat> PhieuXuat { get; set; }
        public DbSet<VatTu> VatTus { get; set; }
        public DbSet<Role> Roless { get; set; }
    }
}
