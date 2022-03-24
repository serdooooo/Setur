using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RehberApi.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=TelefonDb;User Id=postgres;Password=1234;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Iletisim>()
                .HasOne<Rehber>(s => s.Rehber)
                .WithMany(g => g.Iletisims)
                .HasForeignKey(s => s.CurrentUUID);
        }
        public DbSet<Rehber> Rehbers { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
    }
}
