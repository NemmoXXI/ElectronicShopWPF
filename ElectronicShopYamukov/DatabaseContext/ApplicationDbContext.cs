using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicShopYamukov.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElectronicShopYamukov.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>(usersConfigration =>
            {
                usersConfigration.HasKey(p => p.Id);
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=123456789;database=ElectronicShop;",
                new MySqlServerVersion(new Version(8, 0, 40)));
        }
    }
}
