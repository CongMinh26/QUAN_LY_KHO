using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class adddb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MAKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HO = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TEN = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DIACHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SOTAIKHOAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SODIENTHOAI = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MAKH);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    MANCC = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TEN = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SODIENTHOAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOTAIKHOAN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.MANCC);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MANV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HO = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TEN = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DIACHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NGAYSINH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LUONG = table.Column<double>(type: "float", nullable: false),
                    TAIKHOAN = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MATKHAU = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MANV);
                });

            migrationBuilder.CreateTable(
                name: "NhanVienClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVienClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVienLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVienLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "NhanVienRole",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVienRole", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "NhanVienTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVienTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolesNV",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesNV", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VatTu",
                columns: table => new
                {
                    MAVT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TENVT = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DVT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOLUONGTON = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VatTu", x => x.MAVT);
                });

            migrationBuilder.CreateTable(
                name: "PhieuNhap",
                columns: table => new
                {
                    MAPN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NGAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MANV = table.Column<int>(type: "int", nullable: false),
                    MANCC = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhap", x => x.MAPN);
                    table.ForeignKey(
                        name: "FK_PhieuNhap_NhaCungCap_MANCC",
                        column: x => x.MANCC,
                        principalTable: "NhaCungCap",
                        principalColumn: "MANCC",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuNhap_NhanVien_MANV",
                        column: x => x.MANV,
                        principalTable: "NhanVien",
                        principalColumn: "MANV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuXuat",
                columns: table => new
                {
                    MAPX = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NGAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MAKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MANV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuXuat", x => x.MAPX);
                    table.ForeignKey(
                        name: "FK_PhieuXuat_KhachHang_MAKH",
                        column: x => x.MAKH,
                        principalTable: "KhachHang",
                        principalColumn: "MAKH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuXuat_NhanVien_MANV",
                        column: x => x.MANV,
                        principalTable: "NhanVien",
                        principalColumn: "MANV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuNhap",
                columns: table => new
                {
                    MAPN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MAVT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SOLUONG = table.Column<int>(type: "int", nullable: false),
                    DONGIA = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuNhap", x => new { x.MAVT, x.MAPN });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhap_PhieuNhap_MAPN",
                        column: x => x.MAPN,
                        principalTable: "PhieuNhap",
                        principalColumn: "MAPN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhap_VatTu_MAVT",
                        column: x => x.MAVT,
                        principalTable: "VatTu",
                        principalColumn: "MAVT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuXuat",
                columns: table => new
                {
                    MAPX = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MAVT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SOLUONG = table.Column<int>(type: "int", nullable: false),
                    DONGIA = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuXuat", x => new { x.MAVT, x.MAPX });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuXuat_PhieuXuat_MAPX",
                        column: x => x.MAPX,
                        principalTable: "PhieuXuat",
                        principalColumn: "MAPX",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuXuat_VatTu_MAVT",
                        column: x => x.MAVT,
                        principalTable: "VatTu",
                        principalColumn: "MAVT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhap_MAPN",
                table: "ChiTietPhieuNhap",
                column: "MAPN");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuXuat_MAPX",
                table: "ChiTietPhieuXuat",
                column: "MAPX");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_MANCC",
                table: "PhieuNhap",
                column: "MANCC");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_MANV",
                table: "PhieuNhap",
                column: "MANV");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuat_MAKH",
                table: "PhieuXuat",
                column: "MAKH");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuat_MANV",
                table: "PhieuXuat",
                column: "MANV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuNhap");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuXuat");

            migrationBuilder.DropTable(
                name: "NhanVienClaims");

            migrationBuilder.DropTable(
                name: "NhanVienLogins");

            migrationBuilder.DropTable(
                name: "NhanVienRole");

            migrationBuilder.DropTable(
                name: "NhanVienTokens");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "RolesNV");

            migrationBuilder.DropTable(
                name: "PhieuNhap");

            migrationBuilder.DropTable(
                name: "PhieuXuat");

            migrationBuilder.DropTable(
                name: "VatTu");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
