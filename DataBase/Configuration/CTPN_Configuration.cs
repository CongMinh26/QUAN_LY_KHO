using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class CTPN_Configuration : IEntityTypeConfiguration<CTPN>
    {
        public void Configure(EntityTypeBuilder<CTPN> builder)
        {
            builder.ToTable("ChiTietPhieuNhap");
            builder.HasKey(x => new { x.MAVT, x.MAPN });
            //  cấu hình n-n đấy
            builder.HasOne(z => z.PhieuNhap).WithMany(c => c.CTPNs)
                .HasForeignKey(c => c.MAPN);
            builder.HasOne(z => z.VatTu).WithMany(c => c.CTPNs)
                .HasForeignKey(c => c.MAVT);
        }
    }
}
