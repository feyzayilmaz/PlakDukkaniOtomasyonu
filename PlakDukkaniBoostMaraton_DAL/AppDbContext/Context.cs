using Microsoft.EntityFrameworkCore;
using PlakDukkaniBoostMaraton_DATA.Entitty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniBoostMaraton_DAL.AppDbContext
{
    public class Context:DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<AdminInfo> Admin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-C22CDF0\\SQLEXPRESS;Database=PlakDükkani ;Trusted_Connection=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasOne(a => a._admin).WithMany(x => x.Albums).HasForeignKey(x => x.AdminId);
            base.OnModelCreating(modelBuilder);
        }



    }
}
