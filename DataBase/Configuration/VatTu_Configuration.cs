using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Configuration
{
    public class VatTu_Configuration : IEntityTypeConfiguration<VatTu>
    {
        public void Configure(EntityTypeBuilder<VatTu> builder)
        {
            builder.ToTable("VatTu");
            builder.HasKey(x => x.MAVT);
            builder.Property(x => x.TENVT).IsRequired().HasMaxLength(200);
            builder.Property(x => x.DVT).IsRequired();
        }
    }
}
