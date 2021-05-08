using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DataBase.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataBase.Configuration
{
    public class Role_Configuration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("RolesNV");
            builder.Property(z => z.Description).IsRequired().HasMaxLength(200);
        }
    }
}
