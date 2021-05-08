using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class PhieuNhap_Configuration : IEntityTypeConfiguration<PhieuNhap>
    {
        public void Configure(EntityTypeBuilder<PhieuNhap> builder)
        {
            builder.ToTable("PhieuNhap");
            builder.HasKey(z => z.MAPN);
            builder.Property(z => z.MANV).IsRequired();
            builder.Property(z => z.MANCC).IsRequired();
            builder.HasOne(z => z.NhaCungCap).WithMany(c => c.PhieuNhaps)
                .HasForeignKey(z => z.MANCC);
            builder.HasOne(z => z.NhanVien).WithMany(c => c.PhieuNhaps)
                .HasForeignKey(z => z.MANV);
        }
    }
}
