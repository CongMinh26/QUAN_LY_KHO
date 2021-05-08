using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class CTPX_Configuration : IEntityTypeConfiguration<CTPX>
    {
        public void Configure(EntityTypeBuilder<CTPX> builder)
        {
            builder.ToTable("ChiTietPhieuXuat");
            builder.HasKey(x => new { x.MAVT, x.MAPX });
            builder.HasOne(z => z.VatTu).WithMany(c => c.CTPXs)
                .HasForeignKey(z => z.MAVT);
            builder.HasOne(z => z.PhieuXuat).WithMany(c => c.CTPXs)
                .HasForeignKey(c => c.MAPX);
        }
    }
}
