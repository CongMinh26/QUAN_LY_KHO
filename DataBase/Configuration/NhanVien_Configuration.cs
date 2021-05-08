using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class NhanVien_Configuration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(z => z.MANV);
            builder.Property(z => z.HO).IsRequired().HasMaxLength(200);
            builder.Property(z => z.TEN).IsRequired().HasMaxLength(200);
            builder.Property(z => z.TAIKHOAN).IsRequired().HasMaxLength(200);
            builder.Property(z => z.MATKHAU).IsRequired().HasMaxLength(200);
        }
    }
}
