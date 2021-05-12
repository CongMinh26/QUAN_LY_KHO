﻿// <auto-generated />
using System;
using DataBase.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataBase.Migrations
{
    [DbContext(typeof(QuanLyDBContext))]
    [Migration("20210508021227_email-NhanVieb")]
    partial class emailNhanVieb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataBase.Entities.CTPN", b =>
                {
                    b.Property<string>("MAVT")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MAPN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("DONGIA")
                        .HasColumnType("float");

                    b.Property<int>("SOLUONG")
                        .HasColumnType("int");

                    b.HasKey("MAVT", "MAPN");

                    b.HasIndex("MAPN");

                    b.ToTable("ChiTietPhieuNhap");
                });

            modelBuilder.Entity("DataBase.Entities.CTPX", b =>
                {
                    b.Property<string>("MAVT")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MAPX")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("DONGIA")
                        .HasColumnType("float");

                    b.Property<int>("SOLUONG")
                        .HasColumnType("int");

                    b.HasKey("MAVT", "MAPX");

                    b.HasIndex("MAPX");

                    b.ToTable("ChiTietPhieuXuat");
                });

            modelBuilder.Entity("DataBase.Entities.KhachHang", b =>
                {
                    b.Property<string>("MAKH")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DIACHI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("HO")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SODIENTHOAI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SOTAIKHOAN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TEN")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("MAKH");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("DataBase.Entities.NhaCungCap", b =>
                {
                    b.Property<string>("MANCC")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EMAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SODIENTHOAI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SOTAIKHOAN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TEN")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("MANCC");

                    b.ToTable("NhaCungCap");
                });

            modelBuilder.Entity("DataBase.Entities.NhanVien", b =>
                {
                    b.Property<int>("MANV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DIACHI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("HO")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LUONG")
                        .HasColumnType("float");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MATKHAU")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("NGAYSINH")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHONE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TAIKHOAN")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("TEN")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MANV");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("DataBase.Entities.PhieuNhap", b =>
                {
                    b.Property<string>("MAPN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MANCC")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MANV")
                        .HasColumnType("int");

                    b.Property<DateTime>("NGAY")
                        .HasColumnType("datetime2");

                    b.HasKey("MAPN");

                    b.HasIndex("MANCC");

                    b.HasIndex("MANV");

                    b.ToTable("PhieuNhap");
                });

            modelBuilder.Entity("DataBase.Entities.PhieuXuat", b =>
                {
                    b.Property<string>("MAPX")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MAKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MANV")
                        .HasColumnType("int");

                    b.Property<DateTime>("NGAY")
                        .HasColumnType("datetime2");

                    b.HasKey("MAPX");

                    b.HasIndex("MAKH");

                    b.HasIndex("MANV");

                    b.ToTable("PhieuXuat");
                });

            modelBuilder.Entity("DataBase.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RolesNV");
                });

            modelBuilder.Entity("DataBase.Entities.VatTu", b =>
                {
                    b.Property<string>("MAVT")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DVT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SOLUONGTON")
                        .HasColumnType("int");

                    b.Property<string>("TENVT")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("MAVT");

                    b.ToTable("VatTu");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("NhanVienClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("NhanVienLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("NhanVienRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("NhanVienTokens");
                });

            modelBuilder.Entity("DataBase.Entities.CTPN", b =>
                {
                    b.HasOne("DataBase.Entities.PhieuNhap", "PhieuNhap")
                        .WithMany("CTPNs")
                        .HasForeignKey("MAPN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBase.Entities.VatTu", "VatTu")
                        .WithMany("CTPNs")
                        .HasForeignKey("MAVT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuNhap");

                    b.Navigation("VatTu");
                });

            modelBuilder.Entity("DataBase.Entities.CTPX", b =>
                {
                    b.HasOne("DataBase.Entities.PhieuXuat", "PhieuXuat")
                        .WithMany("CTPXs")
                        .HasForeignKey("MAPX")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBase.Entities.VatTu", "VatTu")
                        .WithMany("CTPXs")
                        .HasForeignKey("MAVT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuXuat");

                    b.Navigation("VatTu");
                });

            modelBuilder.Entity("DataBase.Entities.PhieuNhap", b =>
                {
                    b.HasOne("DataBase.Entities.NhaCungCap", "NhaCungCap")
                        .WithMany("PhieuNhaps")
                        .HasForeignKey("MANCC")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBase.Entities.NhanVien", "NhanVien")
                        .WithMany("PhieuNhaps")
                        .HasForeignKey("MANV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhaCungCap");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("DataBase.Entities.PhieuXuat", b =>
                {
                    b.HasOne("DataBase.Entities.KhachHang", "KhachHang")
                        .WithMany("PhieuXuats")
                        .HasForeignKey("MAKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBase.Entities.NhanVien", "NhanVien")
                        .WithMany("PhieuXuats")
                        .HasForeignKey("MANV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("DataBase.Entities.KhachHang", b =>
                {
                    b.Navigation("PhieuXuats");
                });

            modelBuilder.Entity("DataBase.Entities.NhaCungCap", b =>
                {
                    b.Navigation("PhieuNhaps");
                });

            modelBuilder.Entity("DataBase.Entities.NhanVien", b =>
                {
                    b.Navigation("PhieuNhaps");

                    b.Navigation("PhieuXuats");
                });

            modelBuilder.Entity("DataBase.Entities.PhieuNhap", b =>
                {
                    b.Navigation("CTPNs");
                });

            modelBuilder.Entity("DataBase.Entities.PhieuXuat", b =>
                {
                    b.Navigation("CTPXs");
                });

            modelBuilder.Entity("DataBase.Entities.VatTu", b =>
                {
                    b.Navigation("CTPNs");

                    b.Navigation("CTPXs");
                });
#pragma warning restore 612, 618
        }
    }
}
