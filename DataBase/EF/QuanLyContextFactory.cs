using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataBase.EF
{
    public class QuanLyContextFactory : IDesignTimeDbContextFactory<QuanLyDBContext> 
    {
        public QuanLyDBContext CreateDbContext(string[] args)
        {
            /*var optionsBuilder = new DbContextOptionsBuilder<QuanLyDBContext>();
            optionsBuilder.UseSqlServer("Server=AD;Database=QuanLyKho;Trusted_Connection=True;");

            return new QuanLyDBContext(optionsBuilder.Options);*/
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("QuanLyKhoDb");

            var optionsBuilder = new DbContextOptionsBuilder<QuanLyDBContext>();
            optionsBuilder.UseSqlServer(connectionString);
           
            return new QuanLyDBContext(optionsBuilder.Options);
        }
    }
}
