using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class PhieuXuat_Configuration : IEntityTypeConfiguration<PhieuXuat>
    {
        public void Configure(EntityTypeBuilder<PhieuXuat> builder)
        {
            builder.ToTable("PhieuXuat");
            builder.HasKey(z => z.MAPX);
            builder.Property(z => z.MANV).IsRequired();
            builder.Property(z => z.MAKH).IsRequired();

            builder.HasOne(z => z.KhachHang).WithMany(c => c.PhieuXuats)
                .HasForeignKey(z => z.MAKH);
            builder.HasOne(z => z.NhanVien).WithMany(c => c.PhieuXuats)
                .HasForeignKey(z => z.MANV);

        }
    }
}
