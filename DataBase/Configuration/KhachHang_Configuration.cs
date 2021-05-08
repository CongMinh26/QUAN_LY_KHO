using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class KhachHang_Configuration : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(z => z.MAKH);
            builder.Property(z => z.HO).IsRequired().HasMaxLength(200);
            builder.Property(z => z.TEN).IsRequired().HasMaxLength(200);
            builder.Property(z => z.EMAIL).IsRequired().HasMaxLength(200);
        }
    }
}
