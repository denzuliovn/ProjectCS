using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.IO;
using Microsoft.Extensions.Configuration.Json;
using BusinessObject;

namespace DataAccessObject
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            // Using IConfiguration to get information from json file.
            builder.UseSqlServer(GetConnectionString());
        }

        string GetConnectionString() // Hàm đọc chuỗi kết nối từ tập tin
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            return config["ConnectionStrings:MyStockDB"];

        }

        public virtual DbSet<AccountMember> AccountMembers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            optionsBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Cate1" },
                new Category { CategoryID = 2, CategoryName = "Cate2" });
        }
    }
}

