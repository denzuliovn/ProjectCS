using BusinessClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClass
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() {}
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            // Using IConfiguration to get information from json file.
            builder.UseSqlServer("Server=DUSTIN;Database=DemoProductCategoryXX;Uid=dustintran;Pwd=cMAROhn111222;TrustServerCertificate=true");
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

